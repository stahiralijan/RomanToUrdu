using CsvHelper;
using Roman_To_Urdu.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Roman_To_Urdu
{
    public partial class RomanToUrdu : Form
    {
        IEnumerable<Word> dictionary;
        StreamReader reader;
        CsvReader csv;

        public RomanToUrdu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var path = AppDomain.CurrentDomain.BaseDirectory;
            reader = new StreamReader(Path.Combine(path, "Dictionary", "urdu-dataset.csv"));
            csv = new CsvReader(reader, CultureInfo.CurrentCulture);

            csv.Configuration.HasHeaderRecord = false;
            csv.Configuration.RegisterClassMap<WordMap>();
            dictionary = csv.GetRecords<Word>();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            var text = Sanitize(textBoxRoman.Text);
            var words = text.Split(' ');
            string urdu = "";

            foreach (string word in words)
            {
                var w = dictionary.Where(x => x.Roman.ToLowerInvariant() == word.Trim().ToLowerInvariant())
                    .FirstOrDefault();

                urdu += (w == null ? word : w.Urdu) + " ";
            }
            textBoxUrdu.Text = urdu;
        }
        
        private string Sanitize(string text)
        {
            var filters = "~!@#$%^&*()_+`-=\\][|}{;':\",./?><".Split();
            var normal = text;
            foreach (string filter in filters)
            {
                normal = normal.Replace(filter, "");
            }
            return normal;
        }

        private void textBoxUrdu_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right && textBoxUrdu.SelectionLength > 0)
            {
                var location = new Point(e.X + textBoxUrdu.Location.X, e.Y + textBoxUrdu.Location.Y);
                contextMenuStrip.Show(textBoxUrdu, e.Location);
            }
        }

        private void RomanToUrdu_FormClosing(object sender, FormClosingEventArgs e)
        {
            csv.Dispose();
            reader.Close();
            reader.Dispose();
        }
    }
}

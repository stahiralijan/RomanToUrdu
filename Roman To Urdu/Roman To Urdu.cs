using CsvHelper;
using LiteDB;
using Roman_To_Urdu.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
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
        Add_Word addWordForm;

        private string ApplicationExecutablePath;
        private string DbDirectory;
        private string DbFilename;

        private LiteDatabase db;

        public RomanToUrdu()
        {
            InitializeComponent();

            addWordForm = new Add_Word();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ApplicationExecutablePath = AppDomain.CurrentDomain.BaseDirectory;

            DbDirectory = ConfigurationManager.AppSettings["DatabaseDirectory"];
            DbFilename = ConfigurationManager.AppSettings["DatabaseName"];

            db = new LiteDatabase(Path.Combine(ApplicationExecutablePath, DbDirectory, DbFilename));
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            var text = Sanitize(textBoxRoman.Text);
            var words = text.Split(' ');
            
            textBoxUrdu.Text = GetTransliteration(words);
        }

        private string GetTransliteration(string[] words)
        {
            string urdu = "";
            try
            {
                var wordDb = db.GetCollection<Word>("words");
                foreach (string word in words)
                {
                    var w = wordDb
                        .Query()
                        .Where(x => x.Roman.Contains(word.Trim().ToLower()))
                        //.Select(x => new Word { Roman = x.Roman, Urdu = x.Urdu, Id = x.Id})
                        .FirstOrDefault();

                    urdu += (w == null ? word : w.Urdu) + " ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return urdu;
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
            
        }

        private void toolStripMenuItemAdd_Click(object sender, EventArgs e)
        {
            addWordForm.WordToAdd = textBoxUrdu.SelectedText.Trim();
            addWordForm.Db = db;
            addWordForm.VisibleChanged += (obj, evt) =>
            {
                if(!addWordForm.Visible)
                {
                    buttonConvert.PerformClick();
                }
            };

            addWordForm.ShowDialog();
        }

        private void buttonCopyUrduText_Click(object sender, EventArgs e)
        {
            if(textBoxUrdu.TextLength > 0)
            {
                Clipboard.SetText(textBoxUrdu.Text);
            }
        }
    }
}

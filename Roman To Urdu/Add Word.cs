using LiteDB;
using Roman_To_Urdu.Entities;
using System;
using System.Windows.Forms;

namespace Roman_To_Urdu
{
    public partial class Add_Word : Form
    {
        private string _wordToAdd = "";

        private LiteDatabase _db;

        public LiteDatabase Db
        {
            set
            {
                if(_db == null)
                {
                    _db = value;
                }
            }
        }

        public string WordToAdd
        {
            set
            {
                _wordToAdd = value;
                textBoxRomanWord.Text = _wordToAdd;
            }

            get
            {
                return _wordToAdd;
            }
        }

        public Add_Word()
        {
            InitializeComponent();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            if (textBoxRomanWord.TextLength == 0)
            {
                errorProvider.SetError(textBoxRomanWord, "Please fill this field");
                return;
            }
            if (textBoxUrduWord.TextLength == 0)
            {
                errorProvider.SetError(textBoxUrduWord, "Please fill this field");
                return;
            }

            try
            {
                var wordsDb = _db.GetCollection<Word>();

                wordsDb.Insert(new Word
                {
                    Roman = textBoxRomanWord.Text,
                    Urdu = textBoxUrduWord.Text
                });

                wordsDb.EnsureIndex(x => x.Roman);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            textBoxRomanWord.Clear();
            textBoxUrduWord.Clear();
            this.Hide();
        }

        private void textBoxUrduWord_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Shift || e.KeyCode == Keys.ShiftKey)
            {
                switch (e.KeyCode)
                {
                    case Keys.A:
                        textBoxUrduWord.AppendText("آ");
                        break;
                    case Keys.B:
                        textBoxUrduWord.AppendText("ؓ");
                        break;
                    case Keys.C:
                        textBoxUrduWord.AppendText("ث");
                        break;
                    case Keys.D:
                        textBoxUrduWord.AppendText("ڈ");
                        break;
                    case Keys.E:
                        textBoxUrduWord.AppendText("ؑ");
                        break;
                    case Keys.F:
                        textBoxUrduWord.AppendText("ٖ");
                        break;
                    case Keys.G:
                        textBoxUrduWord.AppendText("غ");
                        break;
                    case Keys.H:
                        textBoxUrduWord.AppendText("ح");
                        break;
                    case Keys.I:
                        textBoxUrduWord.AppendText("ٰ");
                        break;
                    case Keys.J:
                        textBoxUrduWord.AppendText("ض");
                        break;
                    case Keys.K:
                        textBoxUrduWord.AppendText("خ");
                        break;
                    case Keys.L:
                        textBoxUrduWord.AppendText("ؒ");
                        break;
                    case Keys.M:
                        textBoxUrduWord.AppendText("إ");
                        break;
                    case Keys.N:
                        textBoxUrduWord.AppendText("ں");
                        break;
                    case Keys.O:
                        textBoxUrduWord.AppendText("ۃ");
                        break;
                    case Keys.P:
                        textBoxUrduWord.AppendText("ُ");
                        break;
                    case Keys.Q:
                        textBoxUrduWord.AppendText("ْ");
                        break;
                    case Keys.R:
                        textBoxUrduWord.AppendText("ڑ");
                        break;
                    case Keys.S:
                        textBoxUrduWord.AppendText("ص");
                        break;
                    case Keys.T:
                        textBoxUrduWord.AppendText("ٹ");
                        break;
                    case Keys.U:
                        textBoxUrduWord.AppendText("ٗ");
                        break;
                    case Keys.V:
                        textBoxUrduWord.AppendText("ظ");
                        break;
                    case Keys.W:
                        textBoxUrduWord.AppendText("ﷺ");
                        break;
                    case Keys.X:
                        textBoxUrduWord.AppendText("ژ");
                        break;
                    case Keys.Y:
                        textBoxUrduWord.AppendText("؁");
                        break;
                    case Keys.Z:
                        textBoxUrduWord.AppendText("ذ");
                        break;
                }
            }

            switch(e.KeyCode)
            {
                case Keys.A:
                    textBoxUrduWord.AppendText("ا");
                    break;
                case Keys.B:
                    textBoxUrduWord.AppendText("ب");
                    break;
                case Keys.C:
                    textBoxUrduWord.AppendText("چ");
                    break;
                case Keys.D:
                    textBoxUrduWord.AppendText("د");
                    break;
                case Keys.E:
                    textBoxUrduWord.AppendText("ع");
                    break;
                case Keys.F:
                    textBoxUrduWord.AppendText("ف");
                    break;
                case Keys.G:
                    textBoxUrduWord.AppendText("گ");
                    break;
                case Keys.H:
                    textBoxUrduWord.AppendText("ھ");
                    break;
                case Keys.I:
                    textBoxUrduWord.AppendText("ی");
                    break;
                case Keys.J:
                    textBoxUrduWord.AppendText("ج");
                    break;
                case Keys.K:
                    textBoxUrduWord.AppendText("ک");
                    break;
                case Keys.L:
                    textBoxUrduWord.AppendText("ل");
                    break;
                case Keys.M:
                    textBoxUrduWord.AppendText("م");
                    break;
                case Keys.N:
                    textBoxUrduWord.AppendText("ن");
                    break;
                case Keys.O:
                    textBoxUrduWord.AppendText("ہ");
                    break;
                case Keys.P:
                    textBoxUrduWord.AppendText("پ");
                    break;
                case Keys.Q:
                    textBoxUrduWord.AppendText("ق");
                    break;
                case Keys.R:
                    textBoxUrduWord.AppendText("ر");
                    break;
                case Keys.S:
                    textBoxUrduWord.AppendText("س");
                    break;
                case Keys.T:
                    textBoxUrduWord.AppendText("ت");
                    break;
                case Keys.U:
                    textBoxUrduWord.AppendText("ئ");
                    break;
                case Keys.V:
                    textBoxUrduWord.AppendText("ط");
                    break;
                case Keys.W:
                    textBoxUrduWord.AppendText("و");
                    break;
                case Keys.X:
                    textBoxUrduWord.AppendText("ش");
                    break;
                case Keys.Y:
                    textBoxUrduWord.AppendText("ے");
                    break;
                case Keys.Z:
                    textBoxUrduWord.AppendText("ز");
                    break;
            }

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                buttonAdd.PerformClick();
            }

            if (!IsCommandKey(e))
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private bool IsCommandKey(KeyEventArgs evt)
        {
            switch (evt.KeyCode)
            {
                case Keys.Control:
                case Keys.ControlKey:
                case Keys.LControlKey:
                case Keys.RControlKey:
                case Keys.Back:
                case Keys.Return:
                case Keys.Delete:
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:
                case Keys.Right:
                case Keys.Tab:
                case Keys.BrowserBack:
                case Keys.BrowserFavorites:
                case Keys.BrowserForward:
                case Keys.BrowserHome:
                case Keys.BrowserRefresh:
                case Keys.BrowserSearch:
                case Keys.BrowserStop:
                case Keys.Cancel:
                case Keys.Clear:
                case Keys.Decimal:
                case Keys.End:
                case Keys.Escape:
                case Keys.F1:
                case Keys.F2:
                case Keys.F3:
                case Keys.F4:
                case Keys.F5:
                case Keys.F6:
                case Keys.F7:
                case Keys.F8:
                case Keys.F9:
                case Keys.F10:
                case Keys.F11:
                case Keys.F12:
                case Keys.Home:
                case Keys.Insert:
                case Keys.Next:
                case Keys.NumLock:
                case Keys.Print:
                case Keys.PrintScreen:
                case Keys.RWin:
                case Keys.Scroll:
                case Keys.PageUp:
                case Keys.LWin:
                case Keys.Sleep:
                case Keys.Zoom:

                    return true;
            }

            return false;
        }

        private void Add_Word_Shown(object sender, EventArgs e)
        {
            textBoxUrduWord.Focus();
        }
    }
}

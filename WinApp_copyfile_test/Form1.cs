using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WinApp_copyfile_test.Utility;

namespace WinApp_copyfile_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            init();
        }

        void init()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            textBox_source.AllowDrop = true;
            textBox_source.DragEnter += TextBox_Path_DragEnter;
            textBox_source.DragDrop += TextBox_Path_DragDrop;

            textBox_todir.AllowDrop = true;
            textBox_todir.DragEnter += TextBox_Path_DragEnter;
            textBox_todir.DragDrop += TextBox_Path_DragDrop;

            button_cancel.Click += Button_cancel_Click;
            button_execute.Click += Button_execute_Click;

            this.FormClosing += Form1_FormClosing;

            progressBar_filecopy.Maximum = 1000;

            button_cancel.Enabled = false;

        }

        private bool _formclosing = false;

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_fileCopyThread != null && !_formclosing)
            {
                e.Cancel = true;

                _formclosing = true;

                _fileCopyThread.Cancel();

            }
        }

        private void TextBox_Path_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void TextBox_Path_DragDrop(object sender, DragEventArgs e)
        {
            TextBox txtbox = (TextBox)sender;

            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;

            string[] path = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            txtbox.Text = path[0];

        }

        private static readonly Color c_textbox_error = Color.Pink;
        private static Color c_textbox_backcolor = SystemColors.Window;

        private void CheckTextBox(TextBox textBox, ref bool check)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.BackColor = c_textbox_error;

                check = false;
            }
            else
            {
                textBox.BackColor = c_textbox_backcolor;
            }
        }

        private void CheckDirTextBox(TextBox textBox, ref bool check)
        {
            string dir = textBox.Text;

            if (!Directory.Exists(dir))
            {
                textBox.BackColor = c_textbox_error;

                check = false;
            }
            else
            {
                textBox.BackColor = c_textbox_backcolor;
            }
        }

        private void CheckFileTextBox(TextBox textBox, ref bool check)
        {
            string file = textBox.Text;

            if (!File.Exists(file))
            {
                textBox.BackColor = c_textbox_error;

                check = false;
            }
            else
            {
                textBox.BackColor = c_textbox_backcolor;
            }
        }

        private void Button_execute_Click(object sender, EventArgs e)
        {
            bool check = true;

            CheckFileTextBox(textBox_source, ref check);
            CheckDirTextBox(textBox_todir, ref check);

            if (!check)
                return;

            string source = textBox_source.Text;
            string todir = textBox_todir.Text;

            string filename = Path.GetFileName(source);
            string topath = Path.Combine(todir, filename);

            // コピー元とコピー先が同じとき
            if (source == topath)
            {
                return;
            }

            // todo:コピー先に同名ファイルが存在したときの対処
            // 1.キャンセル
            // 2.上書き
            // 3.リネームしてコピー
            if (File.Exists(topath))
            {
                DialogResult dlgret = MessageBox.Show(
                    "コピー先に同一名のファイルが存在します。", "",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);

                if (dlgret == DialogResult.Cancel)
                {
                    return;
                }
            }

            button_execute.Enabled = false;
            button_cancel.Enabled = true;

            FileCopyThread fileCopy = new FileCopyThread(this, source, todir);

            fileCopy.ThreadStartEvent += FileCopy_ThreadStartEvent;
            fileCopy.ThreadProgressEvent += FileCopy_ThreadProgressEvent;
            fileCopy.ThreadCompleteEvent += FileCopy_ThreadCompleteEvent;

            _fileCopyThread = fileCopy;

            fileCopy.StartThread();

        }

        FileCopyThread _fileCopyThread = null;

        private void FileCopy_ThreadStartEvent(object sender)
        {
        }

        private void FileCopy_ThreadProgressEvent(object sender, long step, long max)
        {
            label_filesize.Text = string.Format("{0}/{1}", step, max);

            decimal decval1 = (decimal)step / max;
            decimal decval2 = decval1 * 1000;
            int ival = (int)decval2;

            progressBar_filecopy.Value = ival;

        }

        private void FileCopy_ThreadCompleteEvent(object sender, bool cancel)
        {
            button_execute.Enabled = true;
            button_cancel.Enabled = false;

            _fileCopyThread = null;

            if (cancel)
            {
                label_filesize.Text = "";
                progressBar_filecopy.Value = 0;
            }
            else
            {
                MessageBox.Show("完了しました。", "");
            }

            if (_formclosing)
            {
                this.Close();
            }
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            if (_fileCopyThread != null)
            {
                _fileCopyThread.Cancel();
            }
        }

    }
}

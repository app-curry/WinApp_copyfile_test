using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp_copyfile_test
{
    public partial class Form_Selector : Form
    {
        public Form_Selector()
        {
            InitializeComponent();

            init();
        }

        void init()
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            button_copyfile.Click += Button_copyfile_Click;
            button_copydirectory.Click += Button_copydirectory_Click;
        }

        private void Button_copyfile_Click(object sender, EventArgs e)
        {
            Form_CopyFile form = new Form_CopyFile();

            form.ShowDialog(this);

        }

        private void Button_copydirectory_Click(object sender, EventArgs e)
        {
            Form_CopyDirectory form = new Form_CopyDirectory();

            form.ShowDialog(this);
        }
    }
}

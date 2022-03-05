using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIT.WinForm.Control.Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gitDateTimeMask2_Load(object sender, EventArgs e)
        {

        }

        private void gitDateTimeMask3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)Keys.Enter )
            {
                MessageBox.Show(this.gitDateTimeMask3.value.ToString());
            }
        }
    }
}

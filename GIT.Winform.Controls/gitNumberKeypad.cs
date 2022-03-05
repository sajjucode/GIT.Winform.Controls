using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIT.Winform.Controls
{
    public partial class gitNumberKeypad : UserControl
    {
        [Description("Use to set TextBox for value."), Category("GITProperties")]
        public TextBox InputTextBox { get; set; }

        void setValue(string ActionName, string Value)
        {
            try
            {
                switch (ActionName.ToString())
                {
                    case "backspace":
                        if (String.IsNullOrEmpty(this.InputTextBox.Text) == false)
                        {
                            this.InputTextBox.Text = this.InputTextBox.Text.Remove(this.InputTextBox.Text.Length-1, 1);
                        }
                        break;
                    case "clear":
                        this.InputTextBox.Text = string.Empty;
                        break;
                    default:
                        this.InputTextBox.Text = this.InputTextBox.Text.Insert(this.InputTextBox.Text.Length, Value);
                        break;
                }
                

            }
            catch (Exception ex)
            {


            }
        }
        public gitNumberKeypad()
        {
            InitializeComponent();
        }

        private void cmdNum1_Click(object sender, EventArgs e)
        {
            this.setValue("value", "1");
        }

        private void cmdNum2_Click(object sender, EventArgs e)
        {
            this.setValue("value", "2");
        }

        private void cmdNum3_Click(object sender, EventArgs e)
        {
            this.setValue("value", "3");
        }

        private void cmdNum4_Click(object sender, EventArgs e)
        {
            this.setValue("value", "4");
        }

        private void cmdNum5_Click(object sender, EventArgs e)
        {
            this.setValue("value", "5");
        }

        private void cmdNum6_Click(object sender, EventArgs e)
        {
            this.setValue("value", "6");
        }

        private void cmdNum7_Click(object sender, EventArgs e)
        {
            this.setValue("value", "7");
        }

        private void cmdNum8_Click(object sender, EventArgs e)
        {
            this.setValue("value", "8");
        }

        private void cmdNum9_Click(object sender, EventArgs e)
        {
            this.setValue("value", "9");
        }

        private void cmdNum0_Click(object sender, EventArgs e)
        {
            this.setValue("value", "0");
        }

        private void cmdNum10_Click(object sender, EventArgs e)
        {
            this.setValue("value", "10");
        }

        private void cmdNum20_Click(object sender, EventArgs e)
        {
            this.setValue("value", "20");
        }

        private void cmdNum30_Click(object sender, EventArgs e)
        {
            this.setValue("value", "30");
        }

        private void cmdNum50_Click(object sender, EventArgs e)
        {
            this.setValue("value", "50");
        }

        private void cndNum00_Click(object sender, EventArgs e)
        {
            this.setValue("value", "00");
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            this.setValue("clear", "0");
        }

        private void cmdBackspace_Click(object sender, EventArgs e)
        {
            this.setValue("backspace", "0");
        }

        private void cmdNumPoint_Click(object sender, EventArgs e)
        {
            this.setValue("value", ".");
        }

        private void cmdEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Parent is Form)
                {
                    ((Form)this.Parent).DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                
                
            }
        }
    }
}

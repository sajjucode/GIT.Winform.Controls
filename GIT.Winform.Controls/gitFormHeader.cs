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
    public partial class gitFormHeader : UserControl
    {
        [Description("Use to Set Heading"), Category("GITProperties")]
        public String Heading
        {
            get
            {
                return this.lblHeading.Text;
            }
            set
            {
                this.lblHeading.Text = value;
            }
        }

        //[Description("Use to Set Heading Button Properties"), Category("GITProperties")]
        //public Button HeadingButton
        //{
        //    get
        //    {
        //        return this.cmdHeadingButton;
        //    }
        //}

        [Description("Use to Set Searching Textbox"), Category("GITProperties")]
        public GIT.Winform.Controls.gitTextBox SearchingTextBox
        {
            get
            {
                return SearchgitTextBox;
            }
        }

        [Description("Use to Set Search Button Properties"), Category("GITProperties")]
        public Button SearchButtons
        {
            get
            {
                return this.cmdSearch;
            }
        }

        #region "Close"
        [Description("Use to Set Closing Button Properties"), Category("GITProperties.Controls")]
        public Button CloseButton
        {
            get
            {
                return this.cmdClose;
            }

        }

        [Description("Use to Set Heading Picture Button Properties."), Category("GITProperties.Controls")]
        public Button HeadingButton
        {
            get
            {
                return this.cmdHeadingButton;
            }
        }

        [Description("Use to Set Heading Label Properties."), Category("GITProperties.Controls")]
        public Label HeadingLabel
        {
            get
            {
                return this.lblHeading;
            }
        }

        [Description("Use to Set Search Button Properties."), Category("GITProperties.Controls")]
        public Button SearchButton
        {
            get
            {
                return this.cmdSearch;
            }
        }

        [Description("Use to Set Search Text Properties."), Category("GITProperties.Controls")]
        public gitTextBox SearchTextBox
        {
            get
            {
                return this.SearchgitTextBox;
            }
        }

        [Description("Use to Set Minimize Button Properties"), Category("GITProperties.Controls")]
        public Button MinimuzeButton
        {
            get
            {
                return this.cmdMinimuze;
            }
        }

        [Description("Use to Set Main Heading BG Properties"), Category("GITProperties.Controls")]
        public Panel HeadingBG
        {
            get
            {
                return this.pnlHeader;
            }
        }

        [Description("Use to Set Search Panel Properties"), Category("GITProperties.Controls")]
        public Panel SearchBG
        {
            get
            {
                return this.pnlSearch;
            }
        }

        #endregion
        public gitFormHeader()
        {
            InitializeComponent();
            this.Dock = DockStyle.Top;
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            try
            {

                this.ParentForm.Close();
            }
            catch (Exception ex)
            {


            }
        }

        private void cmdMinimuze_Click(object sender, EventArgs e)
        {
            try
            {
                this.ParentForm.WindowState = FormWindowState.Minimized;
            }
            catch (Exception ex)
            {


            }
        }
    }
}

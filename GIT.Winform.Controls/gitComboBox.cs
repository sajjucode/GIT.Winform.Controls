using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GIT.Winform.Controls.CommonSettings;

namespace GIT.Winform.Controls
{
    public partial class gitComboBox : ComboBox
    {
        #region "Appearances"
        [Description("Use to set Forecolor when control focused or active."), Category("GITProperties")]
        public Color onFocusColor { get; set; }

        [Description("Use to set Font style when control focused or active."), Category("GITProperties")]
        public Font onFocusFont { get; set; }

        [Description("Use to set Background when control focused or active."), Category("GITProperties")]
        public Color onFocusBackGround { get; set; }

        [Description("Use to set Forecolor when control focused left."), Category("GITProperties")]
        public Color onLostColor { get; set; }
        [Description("Use to set Background when control focused left."), Category("GITProperties")]
        public Color onLostBackGround { get; set; }

        [Description("Use to set Font when control focused left."), Category("GITProperties")]
        public Font onLostFont { get; set; }

        [Description("Use to set Control use user specified design?"), Category("GITProperties"), DefaultValue("False")]
        public Boolean isUseCurrentStyle { get; set; }
        #endregion
        #region "Keys etc"
        [Description("Use to set Control to be focused on Enter key."), Category("GITProperties")]
        public Control OnEnterNextControl { get; set; }
        #endregion
        #region "Misc"
        public Boolean _onFocusAutoDropDown = true;
        [Description("Use to set auto drop on Focus."), Category("GITProperties")]
        public Boolean onFocusAutoDropDown 
        { 
            get
            {
                return _onFocusAutoDropDown;
            }
            set
            {
                _onFocusAutoDropDown = value;
            }
        }
        #endregion

        public gitComboBox()
        {
            InitializeComponent();
        }

        private void gitComboBox_Enter(object sender, EventArgs e)
        {
            try
            {
                if (isUseCurrentStyle == true)
                {
                    this.ForeColor = this.onFocusColor;
                    this.BackColor = this.onFocusBackGround;
                    this.Font = this.onFocusFont;
                }
                else
                {
                    this.ForeColor = Stylings.onFocusColor;
                    this.BackColor = Stylings.onFocusBackGround;
                    this.Font = Stylings.onFocusFont;
                }

                this.DroppedDown = _onFocusAutoDropDown;
            }
            catch (Exception ex)
            {


            }
        }

        private void gitComboBox_Leave(object sender, EventArgs e)
        {
            try
            {
                if (isUseCurrentStyle == true)
                {
                    this.ForeColor = this.onLostColor;
                    this.BackColor = this.onLostBackGround;
                    this.Font = this.onLostFont;
                }
                else
                {
                    this.ForeColor = Stylings.onLostColor;
                    this.BackColor = Stylings.onLostBackGround;
                    this.Font = Stylings.onLostFont;
                }
            }
            catch (Exception ex)
            {


            }
        }

        private void gitComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (this.OnEnterNextControl != null)
                    {
                        this.OnEnterNextControl.Focus();
                    }
                }
            }
            catch (Exception ex)
            {


            }
        }
    }
}

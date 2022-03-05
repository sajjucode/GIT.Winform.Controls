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
    public partial class gitDateTimePicker : DateTimePicker
    {
        #region "Keys etc"
        [Description("Use to set Control to be focused on Enter key."), Category("GITProperties")]
        public Control OnEnterNextControl { get; set; }
        #endregion
        public gitDateTimePicker()
        {
            InitializeComponent();
        }

        private void gitDateTimePicker_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar==(char)Keys.Enter)
                {
                    this.OnEnterNextControl.Focus();
                }
            }
            catch (Exception ex)
            {
                
                
            }
        }
    }
}

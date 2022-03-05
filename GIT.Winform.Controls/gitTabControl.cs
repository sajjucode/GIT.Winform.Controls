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
    public partial class gitTabControl : TabControl
    {
        //private TabAppearance _TabAppearance = new TabAppearance();
        //private Boolean _gitDefaultSetting = true;
        //#region "Git Properties"

        //[Description("Set Default Appearance."), Category("GITProperties")]
        //public Boolean gitDefaultSetting
        //{
        //    get
        //    {
        //        if (_gitDefaultSetting==true)
        //        {
        //            this.Appearance = TabAppearance.Buttons;
        //        }
        //        return _gitDefaultSetting;
        //    }
        //    set
        //    {
        //        if (value == true)
        //        {
        //            this.Appearance = TabAppearance.Buttons;
        //        }
        //        _gitDefaultSetting = value;
        //    }

        //}
        //#endregion
        public gitTabControl()
        {
            InitializeComponent();
            
            this.Appearance = TabAppearance.Buttons;
        }
    }
}

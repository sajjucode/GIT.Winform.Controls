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
    public partial class AppearanceStyle : UserControl
    {
        [Description("Use to set Font when control focused or active."), Category("GITProperties")]
        public  Font onFocusFont
        {
            get
            {
                return Stylings.onFocusFont;
            }
            set
            {
                Stylings.onFocusFont = value;
            }
        }

        [Description("Use to set Font when control focus lost."), Category("GITProperties")]
        public Font onLostFont
        {
            get
            {
                return Stylings.onLostFont;
            }
            set
            {
                Stylings.onLostFont = value;
            }
        }


        [Description("Use to set Focus Forecolor."), Category("GITProperties")]
        public Color onFocusColor 
        {
            get
            {
                return Stylings.onFocusColor;
            }
            set
            {
                Stylings.onFocusColor = value;
            }
        }

        [Description("Use to Set Lost Forecolor."), Category("GITProperties")]
        public Color onLostColor
        {
            get
            {
                return Stylings.onLostColor;
            }
            set
            {
                Stylings.onLostColor = value;
            }
        }


        [Description("Use to Set Focus BackGround Color."), Category("GITProperties")]
        public Color onFocusBackGround
        {
            get
            {
                return Stylings.onFocusBackGround;
            }
            set
            {
                Stylings.onFocusBackGround = value;
            }
        }

        [Description("Use to Set Lost BackGround Color."), Category("GITProperties")]
        public Color onLostBackGround
        {
            get
            {
                return Stylings.onLostBackGround;
            }
            set
            {
                Stylings.onLostBackGround = value;
            }
        }

        [Description("Use to set & Get Form Heading Properties."), Category("GITProperties")]
        public FormHeadingProperties FormHeadingProperties
        {
            get
            {
                return Stylings.FormHeadingProperites;
            }
            set
            {
                Stylings.FormHeadingProperites = value;
            }
        }


        public AppearanceStyle()
        {
            InitializeComponent();            
        }
    }
}

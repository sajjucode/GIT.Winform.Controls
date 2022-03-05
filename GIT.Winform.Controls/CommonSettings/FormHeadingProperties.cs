using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GIT.Winform.Controls.CommonSettings
{
    public class FormHeadingProperties
    {
        private Image _HeadingBG = global::GIT.Winform.Controls.Properties.Resources.header_Green2;
        private Image _HeadingButtonBG = global::GIT.Winform.Controls.Properties.Resources.HeadingButton1;
        private Font _HeadingTitleFont = new Font("OCR-B-Seagull", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        private Color _HeadingTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));

        private Font _SearchTextBoxFont = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        private Image _SearchButtonBG = global::GIT.Winform.Controls.Properties.Resources.Search;
        private Color _SearchPanelBG = System.Drawing.Color.Lavender;
        


        public Image HeadingBG
        {
            get
            {
                return _HeadingBG;
            }
            set
            {
                _HeadingBG = value;
            }
        }

        public Image HeadingButtonBG
        {
            get
            {
                return _HeadingButtonBG;
            }
            set
            {
                _HeadingButtonBG = value;
            }
        }

        public Font HeadingTitleFont
        {
            get
            {
                return _HeadingTitleFont;
            }
            set
            {
                _HeadingTitleFont = value;
            }
        }

        public Color HeadingTitleForeColor
        {
            get
            {
                return _HeadingTitleForeColor;
            }
            set
            {
                _HeadingTitleForeColor = value;
            }
        }

        public Font SearchTextBoxFont
        {
            get
            {
                return _SearchTextBoxFont;
            }
            set
            {
                _SearchTextBoxFont = value;
            }
        }

        public Color SearchPanelBG
        {
            get
            {
                return _SearchPanelBG;
            }
            set
            {
                _SearchPanelBG = value;
            }
        }

        public Image SearchButtonBG
        {
            get
            {
                return _SearchButtonBG;
            }
            set
            {
                _SearchButtonBG = value;
            }
        }
    }
}

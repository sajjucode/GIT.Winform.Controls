using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIT.Winform.Controls.CommonSettings
{
    public class Stylings
    {
        private static Font _onFocusFont = new Font(new FontFamily("Microsoft Sans Serif"), 9);
        private static Font _onLostFont = new Font(new FontFamily("Microsoft Sans Serif"), 9);
        private static Color _onFocusColor = new Color();
        private static Color _onLostColor = new Color();
        private static Color _onFocusBackGroundColor = new Color();
        private static Color _onLostBackgroundColor = new Color();
        private static FormHeadingProperties _FormHeadingProperties = new FormHeadingProperties();

        public static FormHeadingProperties FormHeadingProperites
        {
            get
            {
                return _FormHeadingProperties;
            }
            set
            {
                _FormHeadingProperties = value;
            }
        }
        public static Font onFocusFont 
        { 
            get
            {
                return _onFocusFont;
            }
            set
            {
                _onFocusFont = value;
            }
        }

        public static Font onLostFont
        {
            get
            {
                return _onLostFont;
            }
            set
            {
                _onLostFont = value;
            }
        }

        public static Color onFocusColor
        {
            get
            {
                return _onFocusColor;
            }
            set
            {
                _onFocusColor = value;
            }
        }

        public static Color onLostColor
        {
            get
            {
                return _onLostColor;
            }
            set
            {
                _onLostColor = value;
            }
        }

        public static Color onFocusBackGround
        {
            get
            {
                return _onFocusBackGroundColor;
            }
            set
            {
                _onFocusBackGroundColor = value;
            }
        }

        public static Color onLostBackGround
        {
            get
            {
                return _onLostBackgroundColor;
            }
            set
            {
                _onLostBackgroundColor = value;
            }
        }

        #region " Date Time"
        private static string _InputDateTimeFormat = "dd/MM/yyyy HH:mm:ss";
        public static string InputDateTimeFormat
        {
            get
            {
                return _InputDateTimeFormat;
            }
            set
            {
                _InputDateTimeFormat = value;
            }
        }
        #endregion


    }
}

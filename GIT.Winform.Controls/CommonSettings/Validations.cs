using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIT.Winform.Controls.CommonSettings
{
    public class Validations
    {
        public static string ReadOnly
        {
            set
            {
            }
            get
            {
                return "Ready only!";
            }


        }

        public static string Required
        {
            get
            {
                return "Required Field";
            }
        }

        public static string OnlyDigit()
        {

            return "Only Integer Allowed";
        }

        public static string Select()
        {

            return "Select Something";
        }

        public static string Decimal
        {
            get
            {
                return "Only Decimals Allowed";
            }
        }

        public static string Numeric
        {
            get
            {
                return "Only Numeric value Allowed";
            }
        }

        public static string NoSpace
        {
            get
            {
                return "Space is not allowed.";
            }
        }

        public static String MinimumValueError(string Value)
        {
            return " Value Should Be Greater or Equal To " + Value;
        }

        public static String MaximumValueError(string Value)
        {
            return " Value Should Not be Greater Than " + Value;
        }

        public static string ValueLimitation(String Minimum, String Maximum)
        {
            return "Value Should Be In ( " + Minimum + " to " + Maximum + " )";
        }


        public static void isNumeric(ErrorProvider epMain, object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                epMain.SetError((Control)sender, Numeric);
                e.Handled = true;
            }
            else
            {
                epMain.Clear();
            }


        }
    }
}

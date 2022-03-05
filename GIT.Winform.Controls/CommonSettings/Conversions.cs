using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIT.Winform.Controls.CommonSettings
{
    public class Conversions
    {
        public static CultureInfo myCulture = CultureInfo.InvariantCulture;
        #region "DateTime"
        public static DateTime StringToDateTime(string inputValue , string inputFormat)
        {
            try
            {
                return DateTime.ParseExact(inputValue, inputFormat, myCulture); 
            }
            catch (Exception ex)
            {

                return DateTime.Now;
            }
        }
        #endregion

        public static int ConvertToInt(string Number)
        {
            int returnInt;
            int.TryParse(Number, out returnInt);
            return returnInt;
        }
        public static Int64 ConvertToInt64(string Number)
        {
            Int64 returnInt;
            Int64.TryParse(Number, out returnInt);
            return returnInt;
        }

        public static decimal ConvertToDecimal(string Number)
        {
            Decimal returnDecimal = 0;
            Decimal.TryParse(Number, out returnDecimal);
            return returnDecimal;
        }
    }
}

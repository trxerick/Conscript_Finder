using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConscriptFinder.Logic
{
    public static class Helper
    {
        public static string ConvertPRIZToConscription(string PRIZ)
        {
            char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            
            string result = "";
            string year = "";

            string FullPRIZDate = PRIZ.Substring(PRIZ.IndexOfAny(digits, 0), 6);

            if (FullPRIZDate.Contains("-1"))
                result += "Весна";
            else
                result += "Осень";

            year = FullPRIZDate.Substring(0, FullPRIZDate.IndexOf("-", 0));

            result += (" " + year);

            return result;
        }
    }
}

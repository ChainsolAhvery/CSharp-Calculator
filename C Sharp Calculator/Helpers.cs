using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C_Sharp_Calculator
{
    class Helpers
    {
        // TODO: This Regex needs adjusted to preserve trailing zeros
        // From: https://stackoverflow.com/questions/16035506/format-a-number-with-commas-and-decimals-in-c-sharp-asp-net-mvc3
        static public string FormatNumber<T>(T number, int maxDecimals = 16)
        {
            return Regex.Replace(String.Format("{0:n" + maxDecimals + "}", number),
                                 @"[" + System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator + "]?0+$", "");
        }
        static public decimal SquareRoot(decimal MainValue)
        {
            decimal Error = Decimal.Multiply(MainValue, (decimal)10e-16);
            decimal Guess = MainValue;
            while (((Guess - MainValue) / Guess) > Error)
            {
                Guess = ((Guess + MainValue) / Guess) / 2;
            }
            return Guess;
        }
    }
}

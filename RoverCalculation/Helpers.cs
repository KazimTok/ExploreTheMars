using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RoverCalculation
{
   public  class Helpers
    {
        public static bool IsNumeric(string value)
        {
            int n;
            bool isNumeric = int.TryParse(value, out n);
            return isNumeric;
        }
        public static bool IsPositiveNumber(string strNumber)
        {
            Regex objNotPositivePattern = new Regex("[^0-9.]");
            Regex objPositivePattern = new Regex(
            "^[.][0-9]+$|[0-9]*[.]*[0-9]+$");
            Regex objTwoDotPattern = new Regex("[0-9]*[.][0-9]*[.][0-9]*");
            return !objNotPositivePattern.IsMatch(strNumber) &&
            objPositivePattern.IsMatch(strNumber) &&
            !objTwoDotPattern.IsMatch(strNumber);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace aww
{
    internal static class ExtentionMethods
    {
        public static bool IsContainsDigit(this string name)
        {
            if (name == null) return false;

            foreach (var cr in name)
            {
                if (char.IsDigit(cr))
                    return true;
            }
            return false;
        }
        public static string ToCapitalize(this string str)
        {
            string newStr = Char.ToUpper(str[0]) + str.Substring(1).ToLower();
            return newStr;
        }
        public static bool IsOdd(this int num1)
        {
            if (num1 % 2 != 0) return true;
            else
            {
                return false;
            }
        }
        public static bool IsEven(this int num2)
        {
            if (num2 % 2 == 0)
                return true;
            else
            {
                return false;
            }
        }
    }
}

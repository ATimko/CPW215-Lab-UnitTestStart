using System;
using System.Text.RegularExpressions;

namespace BusinessLogic
{
    public static class Validator
    {
        /// <summary>
        /// Determines if string is a valid Social Security number
        /// </summary>
        /// <param name="ssn"></param>
        /// <returns></returns>
        public static bool IsSsn(string ssn)
        {
            //throw new NotImplementedException();

            // SSN validates the string
            return Regex.IsMatch(ssn, @"^(?:\d{9}|\d{3}-\d{2}-\d{4})$");
        }

        /// <summary>
        /// Checks if a number is within range
        /// </summary>
        /// <param name="numToTest">The number to test</param>
        /// <param name="minValue">The minimum INCLUSIVE range</param>
        /// <param name="maxValue">The maximum INCLUSIVE range</param>
        /// <returns></returns>
        public static bool IsWithinRange(int numToTest, int minValue, int maxValue)
        {
            //throw new NotImplementedException();

            // If it is within range, it can determine if its true or false
            if (numToTest < minValue || numToTest > maxValue)
            {
                return false;
            }
            return true;
        }
    }
}

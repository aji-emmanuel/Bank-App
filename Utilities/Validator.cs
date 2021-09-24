using System;
using System.Text.RegularExpressions;

namespace Utilities
{
    /// <summary>
    /// Contains methods which validates user's inputs with accepted formats. 
    /// </summary>
    /// 
    public static class Validator
    {
        /// <summary>
        /// This validates the User's Email with the accepted format
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>

        public static bool ValidateEmail(this string input)
        {
            string pattern = "^[a-zA-Z][A-Za-z0-9._]*@[a-z]+\\.[a-z]{2,3}$";
            bool match = Regex.IsMatch(input, pattern);
            if (match)
                return true;
            else
                return false;
        }

        /// <summary>
        /// This validates the User's chosen Password with the accepted format.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>

        public static bool ValidatePassword(this string input)
        {
            string pattern = "^(?=.*[A-Za-z])(?=.*\\d)(?=.*[@$!%*#?&])[A-Za-z\\d@$!%*#?&]{6,}$";
            bool match = Regex.IsMatch(input, pattern);

            if (match)
                return true;
            else
                return false;
        }

        /// <summary>
        /// This validates the User's Name with the accepted format
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>

        public static bool ValidateName(this string input)
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            bool match = Regex.IsMatch(input, pattern);
            if (match)
                return true;
            else
                return false;
        }

        /// <summary>
        /// This validates the inputed Amount
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>

        public static bool ValidateAmount(this string input)
        {
            string pattern = "^[1-9]{1}[0-9]{2,}$";
            bool match = Regex.IsMatch(input, pattern);
            if (match)
                return true;
            else
                return false;
        }

        /// <summary>
        /// This validates the inputed Account Number.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>

        public static bool ValidateAcctNumber(this string input)
        {
            string pattern = "^[0-9]{10}$";
            bool match = Regex.IsMatch(input, pattern);
            if (match)
                return true;
            else
                return false;
        }
    }
}

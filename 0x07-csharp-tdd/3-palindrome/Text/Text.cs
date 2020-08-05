using System;
using System.Linq;
using System.Collections.Generic;

namespace Text
{
    /// <summary>
    /// Str Class
    /// </summary>
    public class Str
    {
        /// <summary>
        /// Method that returns True if a string is a palindrome or False if it’s not.
        /// </summary>
        /// <param name="s">A string to be checked</param>
        /// <returns></returns>
        public static bool IsPalindrome(string s)
        {
            List<char> str = new List<char>();
            foreach (char val in s)
                if (!Char.IsPunctuation(val) && !Char.IsWhiteSpace(val))
                    str.Add(Char.ToLower(val));
            List<char> reversed = new List<char>(str);
            reversed.Reverse();
            return (str.SequenceEqual(reversed));
        }
    }
}

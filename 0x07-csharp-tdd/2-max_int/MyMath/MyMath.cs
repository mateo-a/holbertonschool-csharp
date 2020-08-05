using System;
using System.Collections.Generic;
using System.Linq;

namespace MyMath
{
    /// <summary>
    /// Class Operations
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Method that returns the max integer in a list of integers.
        /// </summary>
        /// <param name="nums">List of integers</param>
        /// <returns></returns>
        public static int Max(List<int> nums)
        {
            if (nums.Any())
            {
                int max = nums.Max();
                return (max);
            } else {
                return (0);
            }
        }
    }
}

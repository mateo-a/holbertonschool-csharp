using System;

namespace Text
{
    /// <summary>
    /// Str class
    /// </summary>
    public class Str
    {
      /// <summary>
      /// Method that returns the index of the first non-repeating character of a string.
      /// </summary>
      /// <param name="s">String</param>
      /// <returns>Index of first non-repeating character or -1 if there is no non-repeating character</returns>

        public static int UniqueChar(string s){
            int pos = 0, count = 0;

            if (s == null) {
                return -1;
            }
            foreach (char val in s)
            {
                for (int i = 0; i < s.Length; i++){
                    if (s[i] == val){
                        count += 1;
                    };
                }
                if (count == 1){
                    return pos;
                }
                count = 0;
                pos += 1;
            }
            return -1;
        }
    }
}

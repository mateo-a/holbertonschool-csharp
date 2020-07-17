using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int num = 0;
        string val = "None";

        foreach (KeyValuePair<string, int> key in myList)
        {
            if (key.Value >= num)
            {
                num = key.Value;
                val = key.Key;
            }
        }
        return val;
    }
}
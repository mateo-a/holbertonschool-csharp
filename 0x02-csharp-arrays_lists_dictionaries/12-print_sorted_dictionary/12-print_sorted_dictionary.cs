using System;
using System.Collections.Generic;


class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<String> lis = new List<string>();
        foreach (string val in myDict.Keys)
        {
            lis.Add(val);
        }
        lis.Sort();
        foreach (string val in lis)
        {
            Console.WriteLine($"{val}: {myDict[val]}");
        }
    }
}

using System;
using System.Collections.Generic;


class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> dic = new Dictionary<string, int>();
        foreach (string val in myDict.Keys)
            dic[val] = myDict[val] * 2;
        return dic;
    }
}

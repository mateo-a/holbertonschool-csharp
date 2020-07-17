using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> lis = new List<bool>();
        foreach (int val in myList)
        {
            if (val % 2 == 0)
                lis.Add(true);
            else
                lis.Add(false);
        }
        return lis;
    }
}

using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> tempList = new List<int>();
        foreach (int num in list1)
        {
            if (!list2.Contains(num))
                tempList.Add(num);
            else
                continue;
        }
        foreach (int num in list2)
        {
            if (!list1.Contains(num))
                tempList.Add(num);
            else
                continue;
        }
        tempList.Sort();
        return (tempList);
    }
}

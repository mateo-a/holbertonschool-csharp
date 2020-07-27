using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        HashSet<int> temp1 = new HashSet<int>(list1);
        HashSet<int> temp2 = new HashSet<int>(list2);

        temp1.IntersectWith(temp2);

        List<int> newList = new List<int>(temp1);

        return newList;
    }
}

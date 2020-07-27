using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        int sum = 0;
        HashSet<int> tempList = new HashSet<int>(myList);

        foreach (var num in tempList)
        {
            sum += num;
        }
        return sum;
    }
}

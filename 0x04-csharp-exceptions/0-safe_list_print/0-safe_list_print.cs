using System;
using System.Collections.Generic;
class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int elements = 0;
        try
        {
            for (elements = 0; elements < n; elements++)
                Console.WriteLine(myList[elements]);
        }
        catch (System.Exception)
        {
            return (elements);
        }
        return (elements);
    }
}
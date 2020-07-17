using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        List <int> lis = new List<int>();
        for (int val = 0; val < size; val++){
            lis.Add(val);
            if (val > 0)
                Console.Write(" ");
            Console.Write(val);
        }
        Console.WriteLine("");
        return lis;
    }
}

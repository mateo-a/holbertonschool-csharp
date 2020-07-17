using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        int[] num = new int[size];
        for (int i = 0; i < size; i++)
        {
            num[i] = i;
            if (i != 0)
                Console.Write(" ");
            Console.Write("{0}", i);
        }
        Console.WriteLine("");
        return num;
    }
}

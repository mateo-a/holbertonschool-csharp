using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array != null)
        {
            for (int val = array.Length - 1; val >= 0; val--)
            {
                if (val < array.Length - 1)
                    Console.Write(" ");
                Console.Write(array[val]);

            }
        }
        Console.WriteLine();
    }
}

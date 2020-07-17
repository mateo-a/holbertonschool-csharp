using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = new int[5, 5];
        array[2, 2] = 1;
        for (int col = 0; col < 5; col++)
        {
            for (int row = 0; row < 5; row++)
            {
                if (row > 0)
                    Console.Write(" ");
                Console.Write(array[col, row]);
            }
            Console.WriteLine("");
        }
    }
}

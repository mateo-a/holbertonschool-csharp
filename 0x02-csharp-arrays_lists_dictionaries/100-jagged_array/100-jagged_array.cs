using System;

namespace _100_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[3][];
            array[0] = new int[4] { 0, 1, 2, 3 };
            array[1] = new int[7] { 0, 1, 2, 3, 4, 5, 6 };
            array[2] = new int[2] { 0, 1 };

            for (int col = 0; col < array.Length; col++)
            {
                for (int row = 0; row < array[col].Length; row++)
                {
                    if (row > 0)
                        Console.Write(" ");
                    Console.Write(array[col][row]);
                }
                Console.WriteLine();
            }
        }
    }
}

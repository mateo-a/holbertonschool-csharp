using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 0; x <= 9; x++)
                for (int y = (x + 1); y <= 9; y++)
                if (x == 8 && y == 9)
                    Console.Write("{0}{1}\n", x, y);
                else
                    Console.Write("{0}{1}, ", x, y);
        }
    }
}

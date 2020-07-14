using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int n = 0; n <= 99; n++)
                if (n == 99)
                    Console.Write("{0:D2}\n", n);
                else
                    Console.Write("{0:D2}, ", n);
        }
    }
}

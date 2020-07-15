﻿using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length <= 0)
            Console.WriteLine("\n");
        else
        {
            for (int i = 1; i <= length; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(" ");
                Console.WriteLine("\\");
            }
        }
    }
}

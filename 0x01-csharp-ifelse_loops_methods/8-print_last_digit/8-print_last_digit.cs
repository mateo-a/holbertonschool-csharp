using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int i = number % 10;
        if (i < 0)
            i = i * -1;
        Console.Write(i);
        return i;
    }
}

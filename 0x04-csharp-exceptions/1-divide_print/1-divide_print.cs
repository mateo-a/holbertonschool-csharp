using System;
class Int
{
    public static void divide(int a, int b)
    // function that divides 2 integers and prints the result.
    {
        int div = 0;
        try
        {
            div = a / b;
        }
        catch
        {
            Console.WriteLine("Cannot divide by zero");
        }
        finally
        {
            Console.WriteLine($"{a} / {b} = {div}");
        }
    }
}

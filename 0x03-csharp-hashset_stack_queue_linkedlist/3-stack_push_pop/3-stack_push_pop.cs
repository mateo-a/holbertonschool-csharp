﻿using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        bool check = aStack.Contains(search);
        Console.WriteLine($"Number of items: {aStack.Count}");
        if (aStack.Count == 0)
            Console.WriteLine("Stack is empty");
        else
            Console.WriteLine($"Top item: {aStack.Peek()}");
        Console.WriteLine($"Stack contains \"{search}\": {check}");
        if (check)
        {
            while (aStack.Pop() != search);
        }
        aStack.Push(newItem);
        return (aStack);
    }
}

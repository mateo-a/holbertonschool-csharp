using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        bool check = aQueue.Contains(search);
        Console.WriteLine($"Number of items: {aQueue.Count}");
        if (aQueue.Count == 0)
            Console.WriteLine("Queue is empty");
        else
            Console.WriteLine($"First item: {aQueue.Peek()}");
        Console.WriteLine($"Queue contains \"{search}\": {check}");
        if (check)
        {
            while (aQueue.Dequeue() != search);
        }
        aQueue.Enqueue(newItem);
        return (aQueue);
    }
}

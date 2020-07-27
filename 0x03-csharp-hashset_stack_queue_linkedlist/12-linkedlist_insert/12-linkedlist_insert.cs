using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> index = myLList.First;

        while (index != null)
        {
            if (n < index.Value)
                return myLList.AddBefore(index, n);
            index = index.Next;
        }
        return myLList.AddLast(n);
    }
}
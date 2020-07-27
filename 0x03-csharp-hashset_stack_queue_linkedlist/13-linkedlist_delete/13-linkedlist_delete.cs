using System;
using System.Collections.Generic;
class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        int i;

        LinkedListNode<int> node = myLList.First;
        for (i = 0; i < index && node.Next != null; i++)
            node = node.Next;
        if (i == index)
            myLList.Remove(node);
    }
}

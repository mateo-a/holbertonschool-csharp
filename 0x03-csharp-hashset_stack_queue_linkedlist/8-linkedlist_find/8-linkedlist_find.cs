using System;
using System.Collections.Generic;
class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        int pos = 0;
        foreach (int val in myLList)
        {
            if (val == value)
                return (pos);
            pos++;
        }
        return (-1);
    }
}

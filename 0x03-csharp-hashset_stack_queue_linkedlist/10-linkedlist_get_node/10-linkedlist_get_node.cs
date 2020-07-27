using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int count = 0;
        foreach (int val in myLList)
        {
            if (count == n)
                return val;
            count++;
        }
        return 0;
    }
}

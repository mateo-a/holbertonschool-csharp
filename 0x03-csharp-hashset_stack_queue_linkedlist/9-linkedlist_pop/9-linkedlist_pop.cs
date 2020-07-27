using System;
using System.Collections.Generic;

class LList
{
  public static int Pop(LinkedList<int> myLList)
  {
    int head = myLList.First.Value;

    if (myLList.First == null)
      return 0;
    myLList.RemoveFirst();
    return head;
  }
}

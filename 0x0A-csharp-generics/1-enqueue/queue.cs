﻿
///<summary>New class called Queue/<T/></summary>
public class Queue<T>
{
    ///<summary>Head of queue</summary>
    public Node head = null;
    ///<summary>Tail of queue</summary>
    public Node tail = null;
    int count = 0;

    ///<summary>New method CheckType() that returns the Queue’s type.</summary>
    public string CheckType()
    {
        return (typeof(T).ToString());
    }

    ///<summary>Public class called Node.</summary>
    public class Node
    {
        ///<summary>Value of node</summary>
        public T value = default(T);
        ///<summary>Next node</summary>
        public Node next = null;

        ///<summary>Constructor</summary>
        public Node(T t)
        {
            value = t;
        }
    }

    ///<summary>Creates a new Node and adds it to the end of the queue.</summary>
    public void Enqueue(T val)
    {
        Node aux = new Node(val);
        if (head == null && tail == null)
        {
            head = aux;
            tail = aux;
        }
        else
        {
            tail.next = aux;
            tail = aux;
        }
        count += 1;
    }
    ///<summary>Returns the number of nodes in the Queue</summary>
    public int Count()
    {
        return (count);
    }
}
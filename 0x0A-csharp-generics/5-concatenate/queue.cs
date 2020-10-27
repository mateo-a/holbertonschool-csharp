using System;

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

    ///<summary>Removes the first node in the queue and returns its value</summary>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return (default(T));
        }
        Node rmv = head;
        head = rmv.next;
        count -= 1;
        return (rmv.value);
    }
    ///<summary>Returns the value of the first node of the queue without removing the node.</summary>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return (default(T));
        }
        return (head.value);
    }

    ///<summary> Prints the queue, starting from the head</summary>
    public void Print()
    {
        Node auxPrint = head;
        if (auxPrint == null)
            Console.WriteLine("Queue is empty");
        while (auxPrint != null)
        {
            Console.WriteLine(auxPrint.value.ToString());
            auxPrint = auxPrint.next;
        }
    }

    ///<summary>Concatenates all values in the queue only if the queue is of type String or Char</summary>
    public string Concatenate()
    {
        string values = "";
        Node auxN = head;
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return (null);
        }
        if (typeof(T) != typeof(string) && typeof(T) != typeof(char))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return (null);
        }
        
        while (auxN != null)
        {
            values = values + auxN.value.ToString();
            if (auxN != tail && typeof(T) == typeof(string))
                values += " ";
            auxN = auxN.next;
        }
        return (values);
    }
}

///<summary>New class called Queue/<T/></summary>
public class Queue<T>
{
    ///<summary>New method CheckType() that returns the Queue’s type.</summary>
    public string CheckType()
    {
        return (typeof(T).ToString());
    }
}
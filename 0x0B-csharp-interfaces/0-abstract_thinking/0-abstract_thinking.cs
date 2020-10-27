using System;

///<summary>Abstract Base class</summary>
public abstract class Base
{
    ///<summary>public property</summary>
    public string name;

    ///<summary>Override ToString() method</summary>
    public override string ToString()
    {
        return (name + " is a " + this.GetType().ToString());
    }
}

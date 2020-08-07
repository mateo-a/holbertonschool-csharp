using System;
using System.Reflection;


///<summary>Checks types.</summary>
class Obj
{
    ///<summary>Prints properties/methods of an object.</summary>
    public static void Print(object myObj)
    {
        TypeInfo obj = myObj.GetType().GetTypeInfo();
        Console.WriteLine($"{obj.Name} Properties:");
        foreach (PropertyInfo val in obj.GetProperties())
        {
            Console.WriteLine($"{val.Name}");
        }
        Console.WriteLine($"{obj.Name} Methods:");
        foreach (MethodInfo val in obj.GetMethods())
        {
            Console.WriteLine($"{val.Name}");
        }
    }
}

using System;

/// <summary>
/// Obj class
/// </summary>
class Obj
{
    /// <summary>
    /// Method that returns True if the object is an instance of, or if the object is an instance of a class that inherited from, Array, otherwise return False.
    /// </summary>
    /// <param name="obj">Object to be checked</param>
    /// <returns>True if the object is an instance of, or if the object is an instance of a class that inherited from, Array, otherwise return False</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        return (obj is Array);
    }
}
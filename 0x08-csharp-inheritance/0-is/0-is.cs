using System;

/// <summary>
/// Obj Class
/// </summary>
class Obj
{
    /// <summary>
    /// Method that returns True if the object is an int, otherwise return False.
    /// </summary>
    /// <param name="obj">Object to be checked</param>
    /// <returns>True if object is an int, otherwise return False.</returns>
    public static bool IsOfTypeInt(object obj)
    {
        return (obj is int);
    }
}

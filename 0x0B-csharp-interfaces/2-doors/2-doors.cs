using System;

/// <summary>Abstract Base class</summary>
abstract class Base
{
    public string name = null;

    /// <summary>Override ToString() method </summary>
    public override string ToString()
    {
        return name + " is a " + this.GetType();
    }
}

/// <summary>Interface called IInteractive</summary>
interface IInteractive
{
    void Interact();
}

/// <summary>Interface called IBreakable</summary>
interface IBreakable
{
    int durability { get; set; }
    void Break();
}

/// <summary>Interface called ICollectable</summary>
interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

/// <summary>Class that inherits from Base and all three interfaces</summary>
class Door : Base, IInteractive
{
    /// <summary>Constructor that sets the value of name</summary>
    public Door(string value = "Door")
    {
        name = value;
    }
    /// <summary>prints: You try to open the /<name/>. It's locked.</summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}

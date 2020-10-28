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
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }
    public bool isCollected
    {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public void Interact()
    {
        throw new NotImplementedException();
    }
    public void Break()
    {
        throw new NotImplementedException();
    }

    public void Collect()
    {
        throw new NotImplementedException();
    }
}

using System;

/// <summary>Class called Key that inherits from Base and ICollectable.</summary>
class Key : Base, ICollectable
{
    ///<summary>define constructor that sets the value of name and isCollected</summary>
    public Key(string name = "Key", bool isCollected = false)
    {
        this.name = name;
        this.isCollected = isCollected;
    }

    ///<summary>iscollected get,set</summary>
    public bool isCollected { get; set; }

    /// <summary>Collect method</summary>
    public void Collect()
    {
        if (isCollected == false)
        {
            isCollected = true;
            Console.WriteLine($"You pick up the {name}.");
        }
        else
        {
            Console.WriteLine($"You have already picked up the {name}.");
        }
    }
}

/// <summary>Class called Decoration that inherits from Base, IInteractive, and IBreakable.</summary>
class Decoration : Base, IInteractive, IBreakable
{
    public bool isQuestItem = false;

    ///<summary>Constructor that sets the value of name, durability, and isQuestItem</summary>
    public Decoration(
        string name = "Decoration",
        int durability = 1,
        bool isQuestItem = false)
    {
        if (durability <= 0)
        {
            throw new Exception("Durability must be greater than 0");
        }

        this.isQuestItem = isQuestItem;
        this.durability = durability;
        this.name = name;
    }

    /// <summary>Durability get, set</summary>
   
    public int durability { get; set; }

    /// <summary>Interact class</summary>
    public void Interact()
    {
        if (durability <= 0)
        {
            Console.WriteLine($"The {name} has been broken.");
        }
        else
        {
            if (isQuestItem == true)
                Console.WriteLine($"You look at the {name}. There's a key inside.");
            else
                Console.WriteLine($"You look at the {name}. Not much to see here.");
        }

    }

    /// <summary>Break class</summary>
    public void Break()
    {
        durability--;
        if (durability > 0)
            Console.WriteLine($"You hit the {name}. It cracks.");
        if (durability == 0)
            Console.WriteLine($"You smash the {name}. What a mess.");
        if (durability < 0)
            Console.WriteLine($"The {name} is already broken.");
    }
}

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

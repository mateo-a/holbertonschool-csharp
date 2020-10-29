using System;
/// <summary>Delegate CalculateHealth that takes a float amount</summary>
public delegate void CalculateHealth(float amount);

/// <summary>Delegate CalculateModifier</summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

///<summary>Enum Modifier with the values Weak, Base, Strong</summary>
public enum Modifier
{
    /// <summary>half of the base value</summary>
    Weak,
    /// <summary>base value</summary>
    Base,
    /// <summary>1.5 times the base value</summary>
    Strong
}

/// <summary>Public class called Player</summary>
public class Player
{
    private string name;
    private float maxHp;
    private float hp;

    /// <summary>Constructor</summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp > 0)
        {
            this.maxHp = maxHp;
        }
        else
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        this.hp = this.maxHp;
    }
    /// <summary>Method PrintHealth</summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }
    /// <summary>TakeDamage method that follow the prototype of the CalculateHealth delegate</summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0)
            damage = 0;
        Console.WriteLine($"{name} takes {damage} damage!");
        ValidateHP(hp - damage);
    }
    /// <summary>HealDamage method that follow the prototype of the CalculateHealth delegate</summary>
    public void HealDamage(float heal)
    {
        if (heal < 0)
            heal = 0;
        Console.WriteLine($"{name} heals {heal} HP!");
        ValidateHP(hp + heal);
    }
    /// <summary>Sets the new value of the Player’s hp</summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
        {
            hp = 0;
        }
        else if (newHp > maxHp)
        {
            hp = maxHp;
        }
        else
        {
            hp = newHp;
        }
    }

/// <summary>Method ApplyModifier that follows the prototype of CalculateModifier</summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
        {
            return baseValue / 2;
        }
        if (modifier == Modifier.Strong)
        {
            return baseValue * 1.5f;
        }
        return baseValue;
    }

}

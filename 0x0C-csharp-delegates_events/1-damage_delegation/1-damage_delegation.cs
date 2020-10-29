using System;
/// <summary>Delegate CalculateHealth that takes a float amount</summary>
public delegate void CalculateHealth(float amount);

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
    }
    /// <summary>HealDamage method that follow the prototype of the CalculateHealth delegate</summary>
    public void HealDamage(float heal)
    {
        if (heal < 0)
            heal = 0;
        Console.WriteLine($"{name} heals {heal} HP!");
    }
}

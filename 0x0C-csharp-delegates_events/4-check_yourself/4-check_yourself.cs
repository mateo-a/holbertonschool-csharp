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
class Player
{
    private string name;
    private float maxHp;
    private float hp;
    public EventHandler<CurrentHPArgs> HPCheck;
    private string status;

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
        this.status = $"{name} is ready to go!";

        HPCheck += CheckStatus;
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
        HPCheck(this, new CurrentHPArgs(hp));
    }
   
    /// <summary>Method CheckStatus</summary>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHp)
        {
            status = $"{name} is in perfect health!";
        }
        else if (e.currentHp >= maxHp / 2)
        {
            status = $"{name} is doing well!";
        }
        else if (e.currentHp >= maxHp / 4)
        {
            status = $"{name} isn't doing too great...";
        }
        else if (e.currentHp > 0)
        {
            status = $"{name} needs help!";
        }
        else
        {
            status = $"{name} is knocked out!";
        }
        System.Console.WriteLine(status);
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
/// <summary>Class CurrentHPArgs that inherits from EventArgs</summary>
class CurrentHPArgs : EventArgs
{
    /// <summary>Public float that cannot be modified</summary>
    public readonly float currentHp;
    
    /// <summary>Constructor</summary>
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}

﻿using System;

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
}

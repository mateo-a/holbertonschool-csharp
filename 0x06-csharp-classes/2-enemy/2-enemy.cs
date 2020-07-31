using System;

namespace Enemies
{
    /// <summary>Public class Zombie that defines a zombie</summary>
    class Zombie
    {
        /// <summary>Public field, health</summary>
        public int health;

        /// <summary>public constructor <code>public Zombie()</code></summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>public constructor <code>public Zombie(int value)</code></summary>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            else
                health = value;
        }
    }
}

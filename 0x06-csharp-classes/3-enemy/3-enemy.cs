using System;

namespace Enemies
{
    /// <summary>Public class Zombie that defines a zombie</summary>
    class Zombie
    {
        // <summary>Private field, health</summary>
        private int health;

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
        ///<summary>Public method that returns the value of health of the Zombie object</summary>
        public int GetHealth()
        {
            return health;
        }
    }
}

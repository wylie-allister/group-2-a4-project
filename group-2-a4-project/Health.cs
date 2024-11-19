using System;
using System.Numerics;

namespace Game10003
{
    class Health
    {
        int maxHealth;
        int currentHealth;

        //Determining max health
        public void Setup()
        {
            maxHealth = 5;
            ResetHealth();
        }
        //Reducing the player's health
        public void ReduceHealth()
        {
            currentHealth -= 1;
            Console.WriteLine(currentHealth);
        }

        //Increasing the player's health
        public void IncreaseHealth()
        {
            currentHealth += 1;
            Console.WriteLine(currentHealth);
        }

        //Resetting the health
        void ResetHealth()
        {
            currentHealth = maxHealth;
        }
    }
}
}

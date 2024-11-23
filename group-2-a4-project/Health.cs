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
        //Reducing the player's health by 1
        public void ReduceHealth()
        {
            currentHealth -= 1;
            Console.WriteLine(currentHealth);
        }

        //Increasing the player's health by 1
        public void IncreaseHealth()
        {
            currentHealth += 1;
            Console.WriteLine(currentHealth);
        }

        //Whenever we want to reset the game, we can reset the health to the max health
        void ResetHealth()
        {
            currentHealth = maxHealth;
        }

        //Visually displaying the players health onto the screen
        public void ShowUI()
        {
            Text.Color = Color.Red;
            Text.Draw("Health:" + currentHealth, 50,50);
        }
    }
}

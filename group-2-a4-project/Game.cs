// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        PlayerInput playerInput = new PlayerInput();

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            playerInput.position.X = Window.Width / 2;
            playerInput.position.Y = Window.Height - 100;
            playerInput.speed = 500; 
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            playerInput.Input();
        }
    }
}

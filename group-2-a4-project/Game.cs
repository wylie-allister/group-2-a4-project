﻿// Include code libraries you need below (use the namespace).
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
            Window.SetSize(600, 600);
            Window.SetTitle("test"); 
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            playerInput.MovePlayer(); 
            Window.ClearBackground(Color.OffWhite); 
        }
    }
}

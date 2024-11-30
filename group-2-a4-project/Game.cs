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
        // Player size and starting position 

        Vector2 playerPosition = new Vector2(150, 300);
        Vector2 PlayerSize = new Vector2(20, 20);




        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        /// The window size
        public void Setup()
        {
            Window.SetSize(600, 600);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        /// Colour of the player character.
        public void Update()
        {
            Draw.FillColor = Color.White;
            Draw.Rectangle(playerPosition, PlayerSize);

        }
    }
}

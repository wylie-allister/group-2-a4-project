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
        Obstacle obstacle;
        PlayerCollision playerCollision;
        

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(600, 600);
            Window.SetTitle("test");
            //adds new obstacle class (could turn into an array for extra difficulty?)
            obstacle = new Obstacle();
            playerCollision = new PlayerCollision();
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.White);
            //draws obstacle, adds wall collision, and updates position
            obstacle.DrawObstacle();
            obstacle.ObstacleWallCollision();
            obstacle.UpdatePosition();


        }
    }
}

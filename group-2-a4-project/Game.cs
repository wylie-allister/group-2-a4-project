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
        Obstacle[] obstacles = new Obstacle[3];
        PlayerCollision playerCollision;
        

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(600, 600);
            //adds new obstacles
            for (int i = 0; i < obstacles.Length; i++)
            {
                Obstacle obstacle = new Obstacle();
                obstacles[i] = obstacle;
            }
            playerCollision = new PlayerCollision();
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.White);
            //draws obstacle, adds wall collision, and updates position
            for (int i = 0; i < obstacles.Length; i++)
            {
                obstacles[i].DrawObstacle();
                obstacles[i].ObstacleWallCollision();
                obstacles[i].UpdatePosition();
            }



        }
    }
}

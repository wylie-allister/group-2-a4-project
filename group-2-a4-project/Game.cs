﻿// Include code libraries you need below (use the namespace).
using System;
using System.Numerics;
using static System.Net.Mime.MediaTypeNames;

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
        Obstacle[] obstacles = new Obstacle[3];
        PlayerCollision playerCollision;
        Health health;
        Score score;
        GameAudio audio;
        

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        /// The window size
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
            
            //Initializing the Health and Score scripts
            health = new Health();
            score = new Score();
            health.Setup();
            score.Setup();

            //Initializing the audio
            audio = new GameAudio();
            audio.LoadAllAudio();
            audio.PlayMusic();

            // Setup player speed and starting position
            playerInput.position.X = Window.Width / 2;
            playerInput.position.Y = Window.Height - 100;
            playerInput.speed = 500;
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        /// Colour of the player character.
        public void Update()
        {
            Window.ClearBackground(Color.Black);
            //draws obstacle, adds wall collision, and updates position
            for (int i = 0; i < obstacles.Length; i++)
            {
                obstacles[i].DrawObstacle();
                obstacles[i].ObstacleWallCollision(score, audio);
                obstacles[i].UpdatePosition();
            }

            //Displays player health onto the screen
            health.ShowUI();

            //Displays player score onto the screen
            score.ShowUI();

            // Class for player input
            playerInput.Input();
        }
    }
}

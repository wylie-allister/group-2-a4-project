// Include code libraries you need below (use the namespace).
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
        GameAudio test = new GameAudio();

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("test");
            Window.SetSize(400, 400);
            test.LoadAllAudio();
            test.PlayMusic();
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            if (Input.IsKeyboardKeyPressed(KeyboardInput.G))
            {
                test.PlayGravity();
            }

            if (Input.IsKeyboardKeyPressed(KeyboardInput.B))
            {
                test.PlayBoom();
            }
        }
    }
}

using System;
using System.Numerics;

namespace Game10003
{
    public class PlayerInput
    {
        public Vector2 position;
        public Vector2 velocity;
        public float speed;

        // Test Player
        public Vector2 size;

        public void MovePlayer()
        {
            // Setup Gravity 
            Vector2 gravity = new Vector2(0, 10);
            bool isGravityInverted = false;

            // Invert Gravity Input 
            if (Input.IsKeyboardKeyPressed(KeyboardInput.Space))
            {
               if (isGravityInverted)
                {
                    isGravityInverted = false; 
                }
               else
                {
                    isGravityInverted = true;
                }
            }

            // Current Gravity State 
            if (isGravityInverted == false)
            {
                // Gravity Pulling Down
                velocity += gravity * Time.DeltaTime;
                position += velocity;
            }
            if (isGravityInverted)
            {
                // Gravity Pulling Up 
                velocity -= gravity * Time.DeltaTime;
                position -= velocity;
            }

            Console.WriteLine(isGravityInverted);
            // Move Player Left 
            if (Input.IsKeyboardKeyDown(KeyboardInput.Left))
            {
                position.X -= speed * Time.DeltaTime;
            }

            // Move Player Right 
            if (Input.IsKeyboardKeyDown (KeyboardInput.Right))
            {
                position.X += speed * Time.DeltaTime;   
            }
        }

        public void DrawPlayer()
        {
            // Test Player
            Draw.Rectangle(position, size);
        }

        public void ConstraintoWindow()
        {
            float playerLeft = position.X;
            float playerRight = position.X + size.X;
            float playerTop = position.Y;
            float playerBottom = position.Y + size.Y;

            bool isTouchingTop = playerTop <= 0;
            bool isTouchingLeft = playerLeft <= 0;
            bool isTouchingRight = playerRight >= Window.Width;
            bool isTouchingBottom = playerBottom >= Window.Height;
        }
    }
}

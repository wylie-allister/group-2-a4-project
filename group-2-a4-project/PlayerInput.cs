using System;
using System.Numerics;

namespace Game10003
{
    public class PlayerInput
    {
        public Vector2 position;
        public Vector2 velocity;
        public float speed;
        bool isGravityInverted = false;

        // Test Player
        public Vector2 size;

        public void MovePlayer()
        {
            // Setup Gravity 
            Vector2 gravity = new Vector2(0, 10);
   
            // Invert Gravity Input 
            if (Input.IsKeyboardKeyPressed(KeyboardInput.Down))
            {
                if (isGravityInverted == true)
                {
                    isGravityInverted = false;
                }
            }

            if (Input.IsKeyboardKeyPressed(KeyboardInput.Up))
            {
                if (isGravityInverted == false)
                {
                    isGravityInverted = true;
                }
            }

            Console.Write(isGravityInverted); 

            if (isGravityInverted == false)
            {
                // Gravity Pulling Down
                velocity += gravity * Time.DeltaTime;
                position += velocity;
            }

            if (isGravityInverted == true)
            {
                // Gravity Pulling Up
                velocity -= gravity * Time.DeltaTime;
                position += velocity;
            }
            
            
            if (Input.IsKeyboardKeyDown(KeyboardInput.Left))
            {
                position.X -= speed * Time.DeltaTime;
            }

            // Move Player Right 
            if (Input.IsKeyboardKeyDown(KeyboardInput.Right))
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

            if (isTouchingTop || isTouchingBottom)
            {
                velocity.Y = -velocity.Y;
            }

            if (isTouchingLeft || isTouchingRight)
            {
                velocity.X = -velocity.X;
            }
        }
    }
}

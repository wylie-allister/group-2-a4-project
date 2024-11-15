using System;
using System.Numerics;

namespace Game10003
{
    public class PlayerInput
    {
        public Vector2 position;
        public Vector2 velocity;
        public float speed; 

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
            }
            if (isGravityInverted)
            {
                // Gravity Pulling Up 
                velocity -= gravity * Time.DeltaTime;
            }
            position += velocity; 

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
    }
}

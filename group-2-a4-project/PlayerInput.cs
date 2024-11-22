﻿using System;
using System.Numerics;

namespace Game10003
{
    public class PlayerInput
    {
        public Vector2 position;
        public Vector2 velocity;
        public float speed;
        bool isGravityInverted = false;

        public void Input()
        {
            // Setup Player Gravity 
            Vector2 gravity = new Vector2(0, 150);
   
            // Input for Downward Gravity
            if (Game10003.Input.IsKeyboardKeyPressed(KeyboardInput.Down))
            {
                if (isGravityInverted == true)
                {
                    isGravityInverted = false;
                }
            }

            // Input for Upward Gravity
            if (Game10003.Input.IsKeyboardKeyPressed(KeyboardInput.Up))
            {
                if (isGravityInverted == false)
                {
                    isGravityInverted = true;
                }
            }

            // Gravity Mechanics 
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
            
            
            // Input for Moving Player Left
            if (Game10003.Input.IsKeyboardKeyDown(KeyboardInput.Left))
            {
                position.X -= speed * Time.DeltaTime;
            }

            // Input for Moving Player Right 
            if (Game10003.Input.IsKeyboardKeyDown(KeyboardInput.Right))
            {
                position.X += speed * Time.DeltaTime;
            }
        }
    }
}

using System;
using System.Numerics;

namespace Game10003;

public class PlayerCollision
{
    Vector2 playerPosition;
    Vector2 playerSize;

    public void Wall()
    {
        //Creates wall collision, i do not have a player class yet
        float playerLeftEdge = playerPosition.X;
        float playerRightEdge = playerPosition.X + playerSize.X;
        float playerTopEdge = playerPosition.Y;
        float playerBottomEdge = playerPosition.Y + playerSize.Y;

        //Defines window parameters, right and left can be defined if needed, but are unneccessary for right now 
        bool topOfWindow = playerTopEdge <= 0;
        bool bottomOfWindow = playerBottomEdge >= Window.Height;

        if (topOfWindow)
        {
            //Insert definitions for what happens here (most likely --health or kill screen, that's not on me though)
            playerPosition.Y = 0;
        }

        if (bottomOfWindow)
        {
            playerPosition.Y = 600;
        }
    }
}

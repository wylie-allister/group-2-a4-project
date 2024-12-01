using System;
using System.Numerics;

namespace Game10003;

public class PlayerCollision
{
    Vector2 playerPosition;
    Vector2 playerSize;

    public void Wall(Player player, Health health)
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
            //Resets player and gives them a game over if they hit top screen
            playerPosition.Y = 0;
            health.gameOver = true;
        }
        else
        {
            health.gameOver = false;
        }

        if (bottomOfWindow)
        {
            //Resets player and gives them a game over if they hit bottom screen
            playerPosition.Y = 600;
            health.gameOver = true;
        }
        else
        {
            health.gameOver = false;
        }
    }
}

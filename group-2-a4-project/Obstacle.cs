using System;
using System.Numerics;

namespace Game10003;

public class Obstacle
{
    Vector2 obstaclePosition = new Vector2 (600, 300);
    Vector2 obstacleSize;
    float speed = 300;
    public Obstacle()
    {
        //obstacle variables
        obstacleSize = new Vector2(100, 50);
        obstaclePosition.Y = Random.Float(0, 600);
    }

    public void UpdatePosition()
    {
        //updates position
       obstaclePosition.X -= Time.DeltaTime * speed;
    }
    public void DrawObstacle()
    {
        //draws obstacle
        Draw.FillColor = Color.Red;
        Draw.Rectangle(obstaclePosition, obstacleSize);
    }
    //obstacle collision, add player class in there \/\/\/
    public void ObstaclePlayerCollision()
    {
        //Import player later
       float playerLeftEdge = playerPosition.X;
       float playerRightEdge = playerPosition.X + playerSize.X;
       float playerTopEdge = playerPosition.Y;
       float playerBottomEdge = playerPosition.Y + playerSize.Y;

        float obstacleLeftEdge = obstaclePosition.X;
        float obstacleRightEdge = obstaclePosition.X + obstacleSize.X;
        float obstacleTopEdge = obstaclePosition.Y;
        float obstacleBottomEdge = obstaclePosition.Y + obstacleSize.Y;

       bool doesOverlapLeft = playerLeftEdge < obstacleRightEdge;
       bool doesOverlapRight = playerRightEdge < obstacleLeftEdge;
       bool doesOverlapTop = playerTopEdge < obstacleBottomEdge;
       bool doesOverlapBottom = playerBottomEdge > obstacleTopEdge;

       bool doesOverlap = doesOverlapLeft && doesOverlapRight && doesOverlapTop && doesOverlapBottom;

       if (doesOverlap = true)
        {
            //insert --score or kill screen here, not my job though so idk
            Console.WriteLine("ping");
        }
    }

    public void ObstacleWallCollision()
    {
        //resets block once it hits the wall (could potentially track score using this?)
        float obstacleLeftEdge = obstaclePosition.X;

        bool leftOfWindow = obstacleLeftEdge <= 0 - obstacleSize.X;

        if (leftOfWindow == true)
        {
            //resets to a random position once it passes the wall
            obstaclePosition.X = Random.Float(1000, 1500);
            obstaclePosition.Y = Random.Float(0, 600);       
        }
    }
}

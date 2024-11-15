using System;
using System.Numerics;

namespace Game10003;

public class Obstacle
{
    Vector2 obstaclePosition = new Vector2 (600, 300);
    Vector2 obstacleSize;
    float speed = 200;

    public Obstacle()
    {
        //obstaclePosition.Y = 300;
        obstacleSize = new Vector2(100, 50);
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
    public void ObstacleCollision()
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
}

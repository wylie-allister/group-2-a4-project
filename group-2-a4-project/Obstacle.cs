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
    //obstacle collision
    public void ObstaclePlayerCollision(Player player, Health health, GameAudio audio)
    {
       
       float playerLeftEdge = player.playerPosition.X;
       float playerRightEdge = player.playerPosition.X + player.playerSize.X;
       float playerTopEdge = player.playerPosition.Y;
       float playerBottomEdge = player.playerPosition.Y + player.playerSize.Y;

       float obstacleLeftEdge = obstaclePosition.X;
       float obstacleRightEdge = obstaclePosition.X + obstacleSize.X;
       float obstacleTopEdge = obstaclePosition.Y;
       float obstacleBottomEdge = obstaclePosition.Y + obstacleSize.Y;

       bool doesOverlapLeft = playerLeftEdge < obstacleRightEdge;
       bool doesOverlapRight = playerRightEdge > obstacleLeftEdge;
       bool doesOverlapTop = playerTopEdge < obstacleBottomEdge;
       bool doesOverlapBottom = playerBottomEdge > obstacleTopEdge;

       bool doesOverlap = doesOverlapLeft && doesOverlapRight && doesOverlapTop && doesOverlapBottom;

       if (doesOverlap == true)
        {
            //reduces health, plays a boom sound, and resets the block back to starting position so it doesn't trip the point counter
            health.ReduceHealth();
            audio.PlayBoom();
            obstaclePosition.X = Random.Float(1000, 1500);
        }
    }

    public void ObstacleWallCollision(Score score, GameAudio audio)
    {
        //resets block once it hits the wall (could potentially track score using this?)
        float obstacleLeftEdge = obstaclePosition.X;

        bool leftOfWindow = obstacleLeftEdge <= 0 - obstacleSize.X;

        if (leftOfWindow == true)
        {
            //resets to a random position once it passes the wall
            obstaclePosition.X = Random.Float(1000, 1500);
            obstaclePosition.Y = Random.Float(0, 600);
            //increases score and plays a blip noise when obstacle passes the player
            score.IncreaseScore();
            audio.PlayGravity();
        }
    }
}

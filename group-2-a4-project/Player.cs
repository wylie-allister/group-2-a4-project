using System;
using System.Numerics;

namespace Game10003;

public class Player
{
    //player size and starting position
    public Vector2 playerPosition = new Vector2(150, 300);
    public Vector2 playerSize = new Vector2(20, 20);

    public void DrawPlayer()
    {
        //draw player
        Draw.FillColor = Color.White;
        Draw.Rectangle(playerPosition, playerSize);
    }
}

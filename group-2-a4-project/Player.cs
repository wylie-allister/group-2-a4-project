using System;
using System.Numerics;

namespace Game10003;

public class Player
{
    //player size and starting position
    Vector2 playerPosition = new Vector2(150, 300);
    Vector2 PlayerSize = new Vector2(20, 20);

    public void DrawPlayer()
    {
        //draw player
        Draw.FillColor = Color.White;
        Draw.Rectangle(playerPosition, PlayerSize);
    }
}

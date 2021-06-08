using Raylib_cs;

public class PlayerMovement
{
    public static bool movDown, movUp, movRight, movLeft;

    public void Move()
    {
        //Player Inputs
        if (Raylib.IsKeyDown(KeyboardKey.KEY_W) && Player.playerPos.Y > 0 + Player.playerSize / 2)
        {
            Player.playerPos.Y -= Player.speed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_A) && Player.playerPos.X > 0 + Player.playerSize / 2)
        {
            Player.playerPos.X -= Player.speed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_S) && Player.playerPos.Y < Program.h - Player.playerSize / 2)
        {
            Player.playerPos.Y += Player.speed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_D) && Player.playerPos.X < Program.w - Player.playerSize / 2)
        {
            Player.playerPos.X += Player.speed;
        }

        //Speed Increase
        if (Raylib.IsKeyDown(KeyboardKey.KEY_SPACE))
        {
            Player.speed = 5;
            Player.playerSize = 120;
        }
        else
        {
            Player.speed = 12.5f;
            Player.playerSize = 100;
        }

        //Texture References
        if (Program.State != "Lose" || Program.State != "Win")
        {
            if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
            {
                movUp = true;
            }
            else
            {
                movUp = false;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
            {
                movLeft = true;
            }
            else
            {
                movLeft = false;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
            {
                movDown = true;
            }
            else
            {
                movDown = false;
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
            {
                movRight = true;
            }
            else
            {
                movRight = false;
            }
        }
    }
}

using Raylib_cs;

public class PlayerMovement
{
    public static bool movDown, movUp, movRight, movLeft;

    public void Move()
    {
        //Player Inputs
        if (Raylib.IsKeyDown(KeyboardKey.KEY_W) && Player.position.Y > 0 + Player.playerSize / 2)
        {
            Player.position.Y -= Player.speed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_A) && Player.position.X > 0 + Player.playerSize / 2)
        {
            Player.position.X -= Player.speed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_S) && Player.position.Y < Program.h - Player.playerSize / 2)
        {
            Player.position.Y += Player.speed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_D) && Player.position.X < Program.w - Player.playerSize / 2)
        {
            Player.position.X += Player.speed;
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

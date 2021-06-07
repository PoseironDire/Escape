using System.Numerics;
using Raylib_cs;


public class Player
{
    // Player settings
    public static float speed = 7.5f;
    public static int playerSize = 100;
    public static float rotation;
    public static Vector2 position = new Vector2(Program.w / 2, Program.h / 2);
    public static int x = (int)position.X;
    public static int y = (int)position.Y;
    public string scoreCounter = "0";
    public float score = 0;

    //Draw The DAMN Player
    public void Draw()
    {
        //Draw Player
        Raylib.DrawCircle(x, y, playerSize / 2, Color.BLANK);
        x = (int)position.X;
        y = (int)position.Y;
    }
    public void Points()
    {
        //Score System

        float distance = position.X - Bot.position2.X;
        if (distance < 0)
        {
            distance *= -1;
        }
        Raylib.DrawText(scoreCounter, x - 12, y - 100, 50, Color.BLACK);

        score += 0.1f * distance;
    }

    //Reset Texture
    public void DrawReset()
    {
        PlayerMovement.movDown = false;
        PlayerMovement.movLeft = false;
        PlayerMovement.movRight = false;
        PlayerMovement.movUp = false;
    }
}

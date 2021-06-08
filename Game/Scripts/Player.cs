using System;
using System.Numerics;
using Raylib_cs;


public class Player
{
    // Player settings
    public static float speed = 5f;
    public static int playerSize = 100;
    public static float rotation;
    public static Vector2 playerPos = new Vector2(100, Program.h / 2);
    public static Vector2 scorePos = new Vector2(Program.w / 2, Program.h / 2);
    public static int x = (int)playerPos.X;
    public static int y = (int)playerPos.Y;
    public static float score = 0;
    public static string scoreCounter = Convert.ToString(score);
    public static int counter = 0;

    //Points System
    public void Points()
    {
        bool areOverlapping = Raylib.CheckCollisionCircles(Bot.botPos, playerSize * 2, playerPos, playerSize / 2);
        if (areOverlapping == true && Program.State == "Game")
        {
            Assets.textColor = new Color(255, 255, 255, 255);
            counter++;
            if (counter! >= 60)
            {
                score++;
                scoreCounter = Convert.ToString(score);
                counter = 0;
            }
        }
        else if (Program.State == "Lose" || Program.State == "Win")
        {
            Assets.textColor = new Color(0, 0, 0, 255);
            Raylib.DrawText(scoreCounter, x - 12, y - 100, 50, Assets.textColor);
        }

        if (areOverlapping == false)
        {
            Assets.textColor = new Color(0, 0, 0, 255);
        }
        if (Program.State == "Game")
        {
            Raylib.DrawText(scoreCounter, Program.w / 2 - 35, Program.h / 2 - 55, 150, Assets.textColor);
        }
    }
    //Player
    public void User()
    {

        //Draw Player
        Raylib.DrawCircle(x, y, playerSize / 2, Color.BLANK);
        x = (int)playerPos.X;
        y = (int)playerPos.Y;
    }

    //Reset Texture
    public void TextureReset()
    {
        PlayerMovement.movDown = false;
        PlayerMovement.movLeft = false;
        PlayerMovement.movRight = false;
        PlayerMovement.movUp = false;
    }
}

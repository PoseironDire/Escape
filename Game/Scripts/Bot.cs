using System.Numerics;
using Raylib_cs;

public class Bot
{
    // Bot & Scanner settings
    public static Vector2 botPos = new Vector2(Program.w - 100, Program.h / 2);
    public static Vector2 scannerPos = new Vector2();
    public static int x2 = (int)botPos.X;
    public static int y2 = (int)botPos.Y;
    public static int x3 = (int)scannerPos.X;
    public static int y3 = (int)scannerPos.Y;
    public static int botSize = 100;
    public static bool resetPos = false;
    public static Vector2 getBotPos = new Vector2();
    public static Vector2 botMovement = new Vector2();

    //Increase Bot Radar Size Based On Its Speed
    public static float BotMovement(float a, float b)
    {
        if (a < 0)
        {
            a *= -1;
        }
        if (b < 0)
        {
            b *= -1;
        }
        float increase = (a + b) / 2;
        return increase;
    }

    public void AI()
    {
        //Convert float to int
        x2 = (int)botPos.X;
        y2 = (int)botPos.Y;
        x3 = (int)scannerPos.X;
        y3 = (int)scannerPos.Y;

        //Bot Movement
        if (Program.State == "Game")
        {
            //Random Movement
            if (resetPos == false)
            {
                int botDistance = Program.generator.Next(20);
                int i = 0;
                i++;
                if (i == botDistance)
                {
                    botDistance = Program.generator.Next(20);
                    botMovement.X = Program.generator.Next(-10, 10);
                    botMovement.Y = Program.generator.Next(-10, 10);
                    i = 0;
                }
                botPos.X += botMovement.X;
                botPos.Y += botMovement.Y;
            }
            //Return From Edge Screen
            else
            {
                botPos.X += botMovement.X;
                botPos.Y += botMovement.Y;
            }

            //Check If Bot Is Out Of Bounds
            if (botPos.X > Program.w / 2 || botPos.Y > Program.h / 2)
            {
                resetPos = false;
            }

            if (botPos.X < botSize / 2)
            {
                resetPos = true;
                getBotPos.X = x2;
                botMovement.X = ((getBotPos.X / Program.w) + 15);
            }
            if (botPos.X > Program.w - botSize / 2)
            {
                resetPos = true;
                getBotPos.X = x2;
                botMovement.X = ((getBotPos.X / Program.w) - 15);
            }
            if (botPos.Y < botSize / 2)
            {
                resetPos = true;
                getBotPos.Y = y2;
                botMovement.Y = ((getBotPos.Y / Program.h) + 15);
            }
            if (botPos.Y > Program.h - botSize / 2)
            {
                resetPos = true;
                getBotPos.Y = y2;
                botMovement.Y = ((getBotPos.Y / Program.h) - 15);
            }
        }
        x3 = (x2 + Player.x) / 2;
        y3 = (y2 + Player.y) / 2;
        float moveSpeed = BotMovement(botMovement.X, botMovement.Y);

        //Draw Bot
        Raylib.DrawCircle(x2, y2, (botSize + (moveSpeed * 6)) * 2, Assets.botRadarColor);
        Raylib.DrawCircle(x2, y2, botSize / 2, Assets.botColor);

        //Draw Scanner
        bool areOverlapping = Raylib.CheckCollisionCircles(botPos, (botSize + (moveSpeed * 6)) * 2, Player.playerPos, Player.playerSize / 2);
        if (areOverlapping == true)
        {
            Raylib.DrawCircle(x3, y3, botSize / 4, Assets.scannerColor);
        }
    }
}

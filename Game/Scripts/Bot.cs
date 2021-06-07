using System.Numerics;
using Raylib_cs;

public class Bot
{
    // Bot settings
    public static Vector2 position2 = new Vector2(Program.w / 2 + 200, Program.h / 2);
    public static int x2 = (int)position2.X;
    public static int y2 = (int)position2.Y;
    public static bool resetPos = false;
    public static Vector2 getBotPos = new Vector2();
    public static Vector2 botMovement = new Vector2();

    public void AI()
    {
        //Convert float to int
        x2 = (int)position2.X;
        y2 = (int)position2.Y;

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
                position2.X += botMovement.X;
                position2.Y += botMovement.Y;
            }
            //Return From Edge Screen
            else
            {
                position2.X += botMovement.X;
                position2.Y += botMovement.Y;
            }

            //Check If Bot Is Out Of Bounds
            if (position2.X > Program.w / 2 || position2.Y > Program.h / 2)
            {
                resetPos = false;
            }

            if (position2.X < Player.playerSize / 2)
            {
                resetPos = true;
                getBotPos.X = x2;
                botMovement.X = ((getBotPos.X / Program.w) + 15);
            }
            if (position2.X > Program.w - Player.playerSize / 2)
            {
                resetPos = true;
                getBotPos.X = x2;
                botMovement.X = ((getBotPos.X / Program.w) - 15);
            }
            if (position2.Y < Player.playerSize / 2)
            {
                resetPos = true;
                getBotPos.Y = y2;
                botMovement.Y = ((getBotPos.Y / Program.h) + 15);
            }
            if (position2.Y > Program.h - Player.playerSize / 2)
            {
                resetPos = true;
                getBotPos.Y = y2;
                botMovement.Y = ((getBotPos.Y / Program.h) - 15);
            }
        }
        //Draw Bot
        Raylib.DrawCircle(x2, y2, Player.playerSize * 2, Assets.botRadarColor);
        Raylib.DrawCircle(x2, y2, Player.playerSize / 2, Assets.botColor);
    }
}

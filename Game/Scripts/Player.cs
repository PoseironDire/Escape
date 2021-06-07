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

    //Draw The DAMN Player
    public void Draw()
    {
        //Draw Player
        Raylib.DrawCircle(x, y, playerSize / 2, Color.BLANK);
    }
}

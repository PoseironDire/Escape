using System.Numerics;
using Raylib_cs;

public class Textures
{
    //Textures
    public static Texture2D steveTexture = Raylib.LoadTexture(@"Images/Steve.png");
    public static Texture2D playerTexture = Raylib.LoadTexture(@"Images/Drone.png");
    public static Texture2D arrowTexture = Raylib.LoadTexture(@"Images/Arrow.png");
    public static Texture2D playButtonTexture = Raylib.LoadTexture(@"Images/StartButton.png");
    public static Texture2D guideButtonTexture = Raylib.LoadTexture(@"Images/GuideButton.png");

    //Totally Unrelated Logic
    public static Vector2 stevePos = new Vector2(Program.w / 2, Program.h - 200);
    public static int steveModifier;

    //Nine Sprites For The Player
    public void ShowPlayer()
    {
        //Static
        if (PlayerMovement.movDown == false && PlayerMovement.movUp == false && PlayerMovement.movLeft == false && PlayerMovement.movRight == false)
        {
            Raylib.DrawTexturePro(
            playerTexture,
            new Rectangle(0, 0, 16, 16), // Source
            new Rectangle(Player.position.X, Player.position.Y, Player.playerSize, Player.playerSize), // Dest(ination)
            new Vector2(Player.playerSize / 2, Player.playerSize / 2), // Origin
            Player.rotation,
            Color.WHITE);
        }
        else
        {
            //Right
            if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
            {
                Raylib.DrawTexturePro(
                playerTexture,
                new Rectangle(16, 0, 16, 16), // Source
                new Rectangle(Player.position.X, Player.position.Y, Player.playerSize, Player.playerSize), // Dest(ination)
                new Vector2(Player.playerSize / 2, Player.playerSize / 2), // Origin
                Player.rotation,
                Color.WHITE);
            }
            //Left
            if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
            {
                Raylib.DrawTexturePro(
                            playerTexture,
                            new Rectangle(32, 0, 16, 16), // Source
                            new Rectangle(Player.position.X, Player.position.Y, Player.playerSize, Player.playerSize), // Dest(ination)
                            new Vector2(Player.playerSize / 2, Player.playerSize / 2), // Origin
                            Player.rotation,
                            Color.WHITE);
            }
            //Up
            if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
            {
                Raylib.DrawTexturePro(
                            playerTexture,
                            new Rectangle(0, 16, 16, 16), // Source
                            new Rectangle(Player.position.X, Player.position.Y, Player.playerSize, Player.playerSize), // Dest(ination)
                            new Vector2(Player.playerSize / 2, Player.playerSize / 2), // Origin
                            Player.rotation,
                            Color.WHITE);
            }
            //Down
            if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
            {
                Raylib.DrawTexturePro(
                            playerTexture,
                            new Rectangle(16, 16, 16, 16), // Source
                            new Rectangle(Player.position.X, Player.position.Y, Player.playerSize, Player.playerSize), // Dest(ination)
                            new Vector2(Player.playerSize / 2, Player.playerSize / 2), // Origin
                            Player.rotation,
                            Color.WHITE);
            }
            //Up Right
            if (Raylib.IsKeyDown(KeyboardKey.KEY_D) && Raylib.IsKeyDown(KeyboardKey.KEY_W))
            {
                Raylib.DrawTexturePro(
                playerTexture,
                new Rectangle(32, 16, 16, 16), // Source
                new Rectangle(Player.position.X, Player.position.Y, Player.playerSize, Player.playerSize), // Dest(ination)
                new Vector2(Player.playerSize / 2, Player.playerSize / 2), // Origin
                Player.rotation,
                Color.WHITE);
            }
            //Up Left
            if (Raylib.IsKeyDown(KeyboardKey.KEY_A) && Raylib.IsKeyDown(KeyboardKey.KEY_W))
            {
                Raylib.DrawTexturePro(
                            playerTexture,
                            new Rectangle(0, 32, 16, 16), // Source
                            new Rectangle(Player.position.X, Player.position.Y, Player.playerSize, Player.playerSize), // Dest(ination)
                            new Vector2(Player.playerSize / 2, Player.playerSize / 2), // Origin
                            Player.rotation,
                            Color.WHITE);
            }
            //Down Right
            if (Raylib.IsKeyDown(KeyboardKey.KEY_D) && Raylib.IsKeyDown(KeyboardKey.KEY_S))
            {
                Raylib.DrawTexturePro(
                            playerTexture,
                            new Rectangle(16, 32, 16, 16), // Source
                            new Rectangle(Player.position.X, Player.position.Y, Player.playerSize, Player.playerSize), // Dest(ination)
                            new Vector2(Player.playerSize / 2, Player.playerSize / 2), // Origin
                            Player.rotation,
                            Color.WHITE);
            }
            //Down Left
            if (Raylib.IsKeyDown(KeyboardKey.KEY_A) && Raylib.IsKeyDown(KeyboardKey.KEY_S))
            {
                Raylib.DrawTexturePro(
                            playerTexture,
                            new Rectangle(32, 32, 16, 16), // Source
                            new Rectangle(Player.position.X, Player.position.Y, Player.playerSize, Player.playerSize), // Dest(ination)
                            new Vector2(Player.playerSize / 2, Player.playerSize / 2), // Origin
                            Player.rotation,
                            Color.WHITE);
            }
        }
    }
    //Shitpost
    public void Steve()
    {
        if (Menu.playButtonSelected == true && Program.UpdateVisual == true)
        {
            int steveSize = 300;
            Raylib.DrawTexturePro(
                steveTexture,
                new Rectangle(0, 0, 600, 600), // Source
                new Rectangle(stevePos.X, stevePos.Y - steveModifier, steveSize, steveSize + steveModifier), // Dest(ination)
                new Vector2(steveSize / 2, steveSize / 2), // Origin
                Player.rotation,
                Color.WHITE);
        }
    }
    //This is also Shitpost
    public void IntentionalBug()
    {
        int spasm = Program.generator.Next(10);
        Textures.steveModifier += spasm;
    }
}
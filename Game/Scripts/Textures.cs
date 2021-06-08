using System;
using System.Numerics;
using System.Collections.Generic;
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

        Raylib.DrawTexturePro(
        playerTexture,
        new Rectangle(0, 0, 16, 16), // Source
        new Rectangle(Player.playerPos.X, Player.playerPos.Y, Player.playerSize, Player.playerSize), // Dest(ination)
        new Vector2(Player.playerSize / 2, Player.playerSize / 2), // Origin
        Player.rotation,
        Color.WHITE);

        //Right
        if (Raylib.IsKeyDown(KeyboardKey.KEY_D) && !Raylib.IsKeyDown(KeyboardKey.KEY_A))
        {
            Raylib.DrawTexturePro(
            playerTexture,
            new Rectangle(16, 0, 16, 16), // Source
            new Rectangle(Player.playerPos.X, Player.playerPos.Y, Player.playerSize, Player.playerSize), // Dest(ination)
            new Vector2(Player.playerSize / 2, Player.playerSize / 2), // Origin
            Player.rotation,
            Color.WHITE);
        }
        //Left
        if (Raylib.IsKeyDown(KeyboardKey.KEY_A) && !Raylib.IsKeyDown(KeyboardKey.KEY_D))
        {
            Raylib.DrawTexturePro(
                        playerTexture,
                        new Rectangle(32, 0, 16, 16), // Source
                        new Rectangle(Player.playerPos.X, Player.playerPos.Y, Player.playerSize, Player.playerSize), // Dest(ination)
                        new Vector2(Player.playerSize / 2, Player.playerSize / 2), // Origin
                        Player.rotation,
                        Color.WHITE);
        }
        //Up
        if (Raylib.IsKeyDown(KeyboardKey.KEY_W) && !Raylib.IsKeyDown(KeyboardKey.KEY_S))
        {
            Raylib.DrawTexturePro(
                        playerTexture,
                        new Rectangle(0, 16, 16, 16), // Source
                        new Rectangle(Player.playerPos.X, Player.playerPos.Y, Player.playerSize, Player.playerSize), // Dest(ination)
                        new Vector2(Player.playerSize / 2, Player.playerSize / 2), // Origin
                        Player.rotation,
                        Color.WHITE);
        }
        //Down
        if (Raylib.IsKeyDown(KeyboardKey.KEY_S) && !Raylib.IsKeyDown(KeyboardKey.KEY_W))
        {
            Raylib.DrawTexturePro(
                        playerTexture,
                        new Rectangle(16, 16, 16, 16), // Source
                        new Rectangle(Player.playerPos.X, Player.playerPos.Y, Player.playerSize, Player.playerSize), // Dest(ination)
                        new Vector2(Player.playerSize / 2, Player.playerSize / 2), // Origin
                        Player.rotation,
                        Color.WHITE);
        }
        //Up Right
        if (Raylib.IsKeyDown(KeyboardKey.KEY_D) && Raylib.IsKeyDown(KeyboardKey.KEY_W) && !Raylib.IsKeyDown(KeyboardKey.KEY_A) && !Raylib.IsKeyDown(KeyboardKey.KEY_S))
        {
            Raylib.DrawTexturePro(
            playerTexture,
            new Rectangle(32, 16, 16, 16), // Source
            new Rectangle(Player.playerPos.X, Player.playerPos.Y, Player.playerSize, Player.playerSize), // Dest(ination)
            new Vector2(Player.playerSize / 2, Player.playerSize / 2), // Origin
            Player.rotation,
            Color.WHITE);
        }
        //Up Left
        if (Raylib.IsKeyDown(KeyboardKey.KEY_A) && Raylib.IsKeyDown(KeyboardKey.KEY_W) && !Raylib.IsKeyDown(KeyboardKey.KEY_D) && !Raylib.IsKeyDown(KeyboardKey.KEY_S))
        {
            Raylib.DrawTexturePro(
                        playerTexture,
                        new Rectangle(0, 32, 16, 16), // Source
                        new Rectangle(Player.playerPos.X, Player.playerPos.Y, Player.playerSize, Player.playerSize), // Dest(ination)
                        new Vector2(Player.playerSize / 2, Player.playerSize / 2), // Origin
                        Player.rotation,
                        Color.WHITE);
        }
        //Down Right
        if (Raylib.IsKeyDown(KeyboardKey.KEY_D) && Raylib.IsKeyDown(KeyboardKey.KEY_S) && !Raylib.IsKeyDown(KeyboardKey.KEY_A) && !Raylib.IsKeyDown(KeyboardKey.KEY_W))
        {
            Raylib.DrawTexturePro(
                        playerTexture,
                        new Rectangle(16, 32, 16, 16), // Source
                        new Rectangle(Player.playerPos.X, Player.playerPos.Y, Player.playerSize, Player.playerSize), // Dest(ination)
                        new Vector2(Player.playerSize / 2, Player.playerSize / 2), // Origin
                        Player.rotation,
                        Color.WHITE);
        }
        //Down Left
        if (Raylib.IsKeyDown(KeyboardKey.KEY_A) && Raylib.IsKeyDown(KeyboardKey.KEY_S) && !Raylib.IsKeyDown(KeyboardKey.KEY_D) && !Raylib.IsKeyDown(KeyboardKey.KEY_W))
        {
            Raylib.DrawTexturePro(
                        playerTexture,
                        new Rectangle(32, 32, 16, 16), // Source
                        new Rectangle(Player.playerPos.X, Player.playerPos.Y, Player.playerSize, Player.playerSize), // Dest(ination)
                        new Vector2(Player.playerSize / 2, Player.playerSize / 2), // Origin
                        Player.rotation,
                        Color.WHITE);
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

    public static List<Rectangle> rects = new List<Rectangle>();
    public static int shrink = 0;
    public static int tint = 255;
    bool flash = true;
    public void Crosser()
    {
        Color crosser = new Color(Textures.tint, 0, 0, 255);
        if (Program.State == "Lose" && flash == true)
        {
            flash = false;
            if (tint > 10)
            {
                tint -= 10;
            }
            shrink += 12;
        }
        else if (Program.State == "Lose" && flash == false)
        {
            shrink -= 8;
            flash = true;
        }
        //Vertical
        Rectangle rec = rects[0];
        rec.x = Player.playerPos.X - Player.playerSize / 2 + shrink;
        rec.y = 0;
        rec.width = Player.playerSize - (shrink * 2);
        rec.height = Program.h;
        rects[0] = rec;
        Raylib.DrawRectangleRec(rec, crosser);

        //Horizontal
        Rectangle rec2 = rects[1];
        rec2.x = 0;
        rec2.y = Player.playerPos.Y - Player.playerSize / 2 + shrink;
        rec2.width = Program.w;
        rec2.height = Player.playerSize - (shrink * 2);
        rects[1] = rec2;
        Raylib.DrawRectangleRec(rec2, crosser);


    }
}
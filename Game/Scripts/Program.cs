using System.Collections.Generic;
using System;
using System.Numerics;
using Raylib_cs;

public class Program
{
    public static int w = 1840;
    public static int h = 1000;
    public static string State = "Start";
    public static bool UpdateVisual;
    public static Random generator = new Random();
    public static List<Rectangle> rects = new List<Rectangle>();
    public static Vector2 mousePos = Raylib.GetMousePosition();

    public static void Main(string[] args)
    {
        Raylib.InitWindow(w, h, "");
        Raylib.InitAudioDevice();
        Raylib.SetMasterVolume(1.0f);
        Raylib.SetTargetFPS(60);
        Raylib.SetExitKey(0);
        Raylib.SetWindowTitle("A Game");
        Image icon = Raylib.LoadImage(@"Images/Cola.png");
        Raylib.SetWindowIcon(icon);
        Bot Bot = new Bot();
        Player P1 = new Player();
        Menu Menus = new Menu();
        PlayerMovement Controller = new PlayerMovement();
        Textures Texture = new Textures();

        rects.Add(new Rectangle());

        while (!Raylib.WindowShouldClose())
        {
            mousePos = Raylib.GetMousePosition();
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Assets.bg);

            if (State == "Start")
            {
                Menus.Start();
                Texture.Steve();
            }
            if (State != "Start")
            {
                P1.Draw();
                Bot.AI();
                Texture.ShowPlayer();
                Menus.CheckWin();
            }
            if (State == "Game")
            {
                Controller.Move();
            }

            bool areOverlapping = Raylib.CheckCollisionCircles(Player.position, Player.playerSize / 2, Bot.position2, Player.playerSize / 2);
            if (areOverlapping == true)
            {
                Raylib.ClearBackground(Color.WHITE);
                Raylib.SetSoundVolume(Assets.screamSound, 1f);
            }
            else
            {
                Raylib.SetSoundVolume(Assets.screamSound, 0f);
                Raylib.PlaySound(Assets.screamSound);
            }
            Raylib.EndDrawing();
            UpdateVisual = true;
        }
    }
}


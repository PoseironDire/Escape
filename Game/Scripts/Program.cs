using System;
using System.Numerics;
using System.Collections.Generic;
using Raylib_cs;

public class Program
{
    public static int w = 1840;
    public static int h = 1000;
    public static string State = "Start";
    public static bool UpdateVisual;
    public static Random generator = new Random();
    public static Vector2 mousePos = Raylib.GetMousePosition();

    public static void Reset()
    {
        if (Raylib.IsKeyDown(KeyboardKey.KEY_R))
        {
            Player.score = 0;
            Player.scoreCounter = Convert.ToString(Player.score);
            Player.counter = 0;
            Player.playerPos = new Vector2(100, Program.h / 2);


            Player.x = (int)Player.playerPos.X;
            Player.y = (int)Player.playerPos.Y;
            Bot.botPos = new Vector2(Program.w - 100, Program.h / 2);
            Textures.stevePos = new Vector2(Program.w / 2, Program.h - 200);
            Bot.resetPos = false;
            State = "Start";
        }
    }

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

        while (!Raylib.WindowShouldClose())
        {
            Textures.rects.Add(new Rectangle());
            Textures.rects.Add(new Rectangle());
            mousePos = Raylib.GetMousePosition();
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Assets.startBG);

            if (State == "Start")
            {
                Menus.Start();
                Texture.Steve();
            }
            if (State == "Guide")
            {
                Bot.AI();
                Texture.ShowPlayer();
                Menus.Guide();
                Texture.Steve();
            }
            else if (State == "Game")
            {
                Controller.Move();
            }
            else if (State == "Lose")
            {
                P1.Points();
                P1.TextureReset();
                Texture.Crosser();
                Reset();
            }
            else if (State == "Win")
            {
                P1.Points();
                Texture.Crosser();
                P1.TextureReset();
            }

            if (State != "Start" && State != "Guide")
            {
                P1.Points();
                P1.User();
                Texture.ShowPlayer();
                Bot.AI();
                Menus.CheckWin();
            }
            else
            {
                Menus.Cursor();
            }
            Raylib.EndDrawing();
            UpdateVisual = true;
        }
    }
}


using System.Collections.Generic;
using System;
using System.Numerics;
using Raylib_cs;

public class Menu
{
    //Start Button
    public static Vector2 playButton = new Vector2(Program.w / 2, Program.h / 2);
    public static float playButtonSize = 200;
    public static bool playButtonSelected;
    public static bool queStart;

    //Guide Button
    public static Vector2 guideButton = new Vector2(Program.w / 2, Program.h - 200);
    public static float guideButtonSize = 200;
    public static bool guideButtonSelected;

    public static int startDelayMaxValue = 10;
    public static int startDelayCurrentValue = 10;

    Textures Texture = new Textures();

    public void Start()
    {
        int cursorX = (int)Program.mousePos.X;
        int cursorY = (int)Program.mousePos.Y;
        //Mouse Cursor
        Raylib.DrawCircle(cursorX, cursorY, 5, Color.GREEN);

        //Play Butten Texture
        Raylib.DrawTexturePro(
            Textures.playButtonTexture,
            new Rectangle(0, 0, 512, 512), // Source
            new Rectangle(playButton.X, playButton.Y, playButtonSize, playButtonSize), // Dest(ination)
            new Vector2(playButtonSize / 2, playButtonSize / 2), // Origin
            Player.rotation,
            Color.WHITE);
        //Select & Press Start Button Functions
        bool leftButtonPressed = Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON);
        playButtonSelected = Raylib.CheckCollisionCircles(playButton, playButtonSize / 2, Program.mousePos, 1);
        if (playButtonSelected == true && leftButtonPressed == true) //Selected & Pressed
        {
            queStart = true;
            Raylib.SetSoundVolume(Assets.playSound, 0f);
            Raylib.PlaySound(Assets.playSound);
            Textures.stevePos.X -= 800;
        }
        else if (playButtonSelected == true) //Selected
        {
            Raylib.SetSoundVolume(Assets.playSound, 1f);
            Raylib.SetSoundVolume(Assets.playButtonSelectSound, 1f);
            Raylib.ClearBackground(Assets.lighterColor);
            playButtonSize = 250;
            Texture.IntentionalBug();
        }
        else //Not Selected
        {
            Textures.steveModifier = 0;
            Raylib.SetSoundVolume(Assets.playButtonSelectSound, 0f);
            Raylib.PlaySound(Assets.playButtonSelectSound);
            playButtonSize = 200;
        }
        //Game Start Delay
        if (queStart == true)
        {
            startDelayCurrentValue--;
            if (startDelayCurrentValue <= 0)
            {
                playButtonSize = 150;
                Program.State = "Game";
                startDelayCurrentValue = startDelayMaxValue;
            }
        }

        //Guide Butten Texture
        Raylib.DrawTexturePro(
            Textures.guideButtonTexture,
            new Rectangle(0, 0, 516, 516), // Source
            new Rectangle(guideButton.X, guideButton.Y, guideButtonSize, guideButtonSize), // Dest(ination)
            new Vector2(guideButtonSize / 2,guideButtonSize / 2), // Origin
            Player.rotation,
            Color.WHITE);
        //Select & Press Guide Button Functions
        guideButtonSelected = Raylib.CheckCollisionCircles(guideButton, guideButtonSize / 2, Program.mousePos, 1);
        if (guideButtonSelected == true && leftButtonPressed == true) //Selected & Pressed
        {
            queStart = true;
            Raylib.SetSoundVolume(Assets.guideSound, 0f);
            Raylib.PlaySound(Assets.guideSound);
        }
        else if (guideButtonSelected == true) //Selected
        {
            Raylib.SetSoundVolume(Assets.guideSound, 1f);
            Raylib.SetSoundVolume(Assets.guideButtonSelectSound, 1f);
            Raylib.ClearBackground(Assets.lighterColor);
            guideButtonSize = 250;
        }
        else //Not Selected
        {
            Raylib.SetSoundVolume(Assets.guideButtonSelectSound, 0f);
            Raylib.PlaySound(Assets.guideButtonSelectSound);
            guideButtonSize = 200;
        }
    }
    public void Guide()
    {

    }
    public void CheckWin()
    {
        int distance = Player.x - Bot.x2;

        if (distance < 0)
        {
            distance *= -1;
        }
    }
}
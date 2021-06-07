using Raylib_cs;

public class Assets
{
    //Sounds
    public static Sound playButtonSelectSound = Raylib.LoadSound("Sounds/playSelect.wav");
    public static Sound playSound = Raylib.LoadSound("Sounds/play.wav");
    public static Sound guideButtonSelectSound = Raylib.LoadSound("Sounds/guideSelect.wav");
    public static Sound guideSound = Raylib.LoadSound("Sounds/guide.wav");
    public static Sound loseSound = Raylib.LoadSound("Sounds/lose.wav");
    //Colors
    public static Color startBG = new Color(50, 50, 50, 255);
    public static Color startBGLighter = new Color(70, 70, 70, 255);
    public static Color guideBG = new Color(50, 100, 100, 255);
    public static Color guideBGLighter = new Color(70, 120, 120, 255);
    public static Color botColor = new Color(200, 0, 0, 255);
    public static Color botRadarColor = new Color(200, 0, 0, 100);
    public static Color scannerColor = new Color(200, 100, 0, 255);
}
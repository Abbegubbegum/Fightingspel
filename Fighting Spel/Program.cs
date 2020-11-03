using System;
using Raylib_cs;

namespace Fighting_Spel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Define global game variables
            string gameState = "intro";
            const int windowX = 1200;
            const int windowY = 800;


            //Define Intro Screen Variables
            //Font size * 2.6 = Font width
            int playButtonRectX = windowX / 3;
            int playButtonRectY = (windowY / 3) * 2;
            int playButtonRectWidth = windowX / 3;
            int playButtonRectHeight = windowY / 6;
            float playButtonFontSizeF = (windowX / 3) / 2.6f - 3;
            int playButtonFontSize = (int)playButtonFontSizeF;
            float playButtonTextWidthF = playButtonFontSize * 2.6f;
            int playButtonTextWidth = (int)playButtonTextWidthF;

            Raylib.InitWindow(windowX, windowY, "Fighting Spel");

            while (!Raylib.WindowShouldClose())
            {
                if (gameState == "intro")
                {
                    //Logik
                    if (Raylib.GetMouseX() >= playButtonRectX && Raylib.GetMouseX() <= playButtonRectX + playButtonRectWidth && Raylib.GetMouseY() >= playButtonRectY && Raylib.GetMouseY() <= playButtonRectY + playButtonRectHeight && Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                    {

                    }

                    //Drawing
                    Raylib.BeginDrawing();

                    Raylib.ClearBackground(Color.BEIGE);
                    Raylib.DrawRectangle(playButtonRectX, playButtonRectY, playButtonRectWidth, playButtonRectHeight, Color.BROWN);
                    Raylib.DrawText("PLAY", playButtonRectX + (playButtonTextWidth / 2 - playButtonTextWidth / 2), playButtonRectY, playButtonFontSize, Color.WHITE);

                    Raylib.EndDrawing();


                }


            }
        }
    }
}

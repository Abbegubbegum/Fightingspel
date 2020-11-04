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
            const int windowY = 900;
            //Define Intro Screen Variables 
            int playButtonRectX = windowX / 3;
            int playButtonRectY = (windowY / 3) * 2;
            int playButtonRectWidth = windowX / 3;
            int playButtonRectHeight = windowY / 6;
            Color buttonColor = Color.BROWN;
            Raylib.InitWindow(windowX, windowY, "Fighting Game");
            while (!Raylib.WindowShouldClose())
            {
                if (gameState == "intro")
                {
                    //Logik 
                    if (Collide(playButtonRectX, playButtonRectY, playButtonRectWidth, playButtonRectHeight, Raylib.GetMouseX(), Raylib.GetMouseY(), 0, 0))
                    {
                        buttonColor = Color.BEIGE;
                        if (Raylib.IsMouseButtonPressed(MouseButton.MOUSE_LEFT_BUTTON))
                        {
                            gameState = "shop";
                        }
                    }
                    else
                    {
                        buttonColor = Color.BROWN;
                    }
                    //Drawing
                    Raylib.BeginDrawing();
                    Raylib.ClearBackground(Color.BLUE);
                    Raylib.DrawText("ARENA BRAWLER", 20, windowY / 5, 135, Color.WHITE);
                    Raylib.DrawRectangle(playButtonRectX, playButtonRectY, playButtonRectWidth, playButtonRectHeight, buttonColor);
                    Raylib.DrawText("PLAY", playButtonRectX + 5, playButtonRectY, 150, Color.WHITE);
                    Raylib.EndDrawing();
                }
                else if (gameState == "shop")
                {
                    Raylib.CloseWindow();
                }
            }
            //Just a general collision detection on two objects rec and p
            static bool Collide(int recX, int recY, int recW, int recH, int pX, int pY, int pW, int pH)
            {
                if (pX + pW >= recX && pX <= recX + recW && pY + pH >= recY && pY <= recY + recH)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
    }
}

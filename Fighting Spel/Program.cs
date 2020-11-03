using System;
using Raylib_cs;

namespace Fighting_Spel
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(800, 600, "Fighting Spel");
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();

                Raylib.EndDrawing();
            }
        }
    }
}

using System;
using Raylib_cs;

namespace Grunder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Raylib!");

            //Starta graphik motor 
            Raylib.InitWindow(800, 600, "Mitt Raylib fönster");

            // Bestäm skärmuppdatering
            Raylib.SetTargetFPS(60);

            //Skapa Skyblue
            Color SkyBlue = new Color(135,206,235,255);

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                // Börja rita
                Raylib.BeginDrawing();

                // Töm ritytan
                Raylib.ClearBackground(Color.SKYBLUE);

                Raylib.DrawCircle(200, 200, 75, Color.DARKBLUE);
                Raylib.DrawCircle(200, 200, 50, Color.WHITE);
                Raylib.DrawCircle(200, 200, 25, Color.RED);


                // Ritat ut på fönstret
                Raylib.EndDrawing();
            }
        }
    }
}    

using System;
using Raylib_cs;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialisering
            //--------------------------------------------------------------------------------------
            const int fönsterB = 800;
            const int fönsterH = 450;

            Raylib.InitWindow(fönsterB, fönsterH, "raylib [cs]");
            Raylib.SetTargetFPS(60);

            // Game state variabler
            float sek = 60;
            string scen = "Scen 0";

            // TODO: Infoga variabler och objekt här
            //--------------------------------------------------------------------------------------

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                // Updatering
                //----------------------------------------------------------------------------------
                // TODO: Uppdatera variabler här
                //----------------------------------------------------------------------------------
                sek -= Raylib.GetFrameTime();

                // Rita
                //----------------------------------------------------------------------------------
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);

                if (scen == "Scen 0")
                {
                    // Rita ut objekt
                    Raylib.DrawText(scen, 10, 10, 50, Color.RED);

                    // Rita ut tiden
                    Raylib.DrawText($"Tid {(int)sek}", 600, 0, 50, Color.RED);

                    // Räkna ned tiden kvar
                    if (sek <= 0)
                    {
                        scen = "Scen 1";
                        sek = 45;
                    }
                }
                else if (scen == "Scen 1")
                {
                    Raylib.DrawText(scen, 10, 10, 50, Color.RED);

                    // Rita ut tiden
                    Raylib.DrawText($"Tid {(int)sek}", 600, 0, 50, Color.RED);

                    
                    if (sek <= 0)
                    {
                        scen = "Slut";
                    }
                }
                else if (scen == "Slut")
                {
                    Raylib.DrawText("Game Over!", 200, 200, 50, Color.RED);
                }

                Raylib.EndDrawing();
                //----------------------------------------------------------------------------------
            }
        }
    }
}
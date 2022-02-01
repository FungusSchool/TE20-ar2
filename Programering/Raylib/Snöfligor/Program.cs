using System;
using Raylib_cs;

namespace Snöflingor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialisering
            //--------------------------------------------------------------------------------------
            const int fönsterB = 800;
            const int fönsterH = 600;

            Raylib.InitWindow(fönsterB, fönsterH, "Snöflingor");
            Raylib.SetTargetFPS(60);


            // TODO: Infoga variabler och objekt här
            // Slumpmotor
            Random generator = new Random();

            int mängd = 200;

            // Skapa plats för många flingor
            Rectangle[] flingor = new Rectangle[mängd];

            //Rectangle snö = new Rectangle(0, 0, 10, 10);


            // Fyll på med flingor
            // Lägg ut dom slumpmässigt

            for (int i = 0; i < flingor.Length; i++)
            {/* 
                int x = generator.Next(20, fönsterB - 20);
                int y = generator.Next(0, fönsterH) - 700;*/
                
                int storlek = generator.Next(2, 7);

                flingor[i] = new Rectangle(0, 0, storlek, storlek);
                flingor[i].x = generator.Next(20, fönsterB - 20);
                flingor[i].y = generator.Next(0, fönsterH) - fönsterH;
            }

            //array för farten dom faller. 
            float[] speeds = new float[mängd];
            for (int i = 0; i < speeds.Length; i++)
            {
                speeds[i] = generator.Next(100, 200)/100f;
            }

            //Placera ut snöflingan
            //snö.x = generator.Next(20, fönsterB - 20);

            //--------------------------------------------------------------------------------------

            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                // Updatering
                //----------------------------------------------------------------------------------
                // TODO: Uppdatera variabler här
                /* snö.y += 1;
                if (snö.y > 600)
                {
                    snö.y = 0;
                    snö.x = generator.Next(20, fönsterB - 20);
                } */

                for (int i = 0; i < flingor.Length; i++)
                {
                    flingor[i].y += speeds[i];

                    if (flingor[i].y > 600)
                    {
                        flingor[i].x = generator.Next(20, fönsterB - 20);
                        flingor[i].y = generator.Next(0, fönsterH) - fönsterH;
                    }
                }



                //----------------------------------------------------------------------------------

                // Rita
                //----------------------------------------------------------------------------------
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.DARKBLUE);

                // Rita ut flingorna
                for (int i = 0; i < flingor.Length; i++)
                {
                    Raylib.DrawRectangleRec(flingor[i], Color.WHITE);
                }


                //Raylib.DrawRectangleRec(snö, Color.WHITE);

                Raylib.EndDrawing();
                //----------------------------------------------------------------------------------
            }
        }
    }
}
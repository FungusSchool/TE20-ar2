using System;
using Raylib_cs;

namespace Dodgers
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
            Random generator = new Random();

            Rectangle coin = new Rectangle(generator.Next(0, fönsterB - 50), generator.Next(-150, -50), 50, 50);
            Rectangle player = new Rectangle(100, fönsterH - 50, 200, 25);
            Rectangle enemy = new Rectangle(generator.Next(0, fönsterB - 50), generator.Next(-150, -50), 50, 50);

            int points = 0;
            int life = 3;
            float time = 0;
            int speedTime = 15;
            int speed = 2;
            //--------------------------------------------------------------------------------------
            // Animationsloopen
            while (!Raylib.WindowShouldClose())
            {
                // Updatering
                //----------------------------------------------------------------------------------
                //Time
                time += Raylib.GetFrameTime();
                //speed
                if (time > speedTime)
                {
                    speedTime += 15;
                    speed += 1;
                }
                //Coin
                coin.y += speed;
                if (coin.y > fönsterH)
                {
                    coin.y = generator.Next(-150, -50);
                    coin.x = generator.Next(0, fönsterB);
                }
                //Enemy
                enemy.y += speed;
                if (enemy.y > fönsterH)
                {
                    enemy.y = generator.Next(-150, -50);
                    enemy.x = generator.Next(0, fönsterB);
                }
                //Input
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT) || Raylib.IsKeyDown(KeyboardKey.KEY_D))
                {
                    if (player.x < fönsterB - 200)
                    {
                        player.x += 5;
                    }
                }
                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT) || Raylib.IsKeyDown(KeyboardKey.KEY_A))
                {
                    if (player.x > 0 )
                    {
                    player.x -= 5;
                    }
                }
                //Kollision
                //with Coin
                if (Raylib.CheckCollisionRecs(player, coin))
                {
                    coin.y = generator.Next(-150, -50);
                    coin.x = generator.Next(0, fönsterB);
                    points += 1; 
                }
                //With Enemy
                if (Raylib.CheckCollisionRecs(player, enemy))
                {
                    enemy.y = generator.Next(-150, -50);
                    enemy.x = generator.Next(0, fönsterB);
                    life -= 1; 
                }
                //----------------------------------------------------------------------------------

                // Rita
                //----------------------------------------------------------------------------------
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.DARKBLUE);

                Raylib.DrawRectangleRec(coin, Color.GOLD);
                Raylib.DrawRectangleRec(player, Color.GRAY);
                Raylib.DrawRectangleRec(enemy, Color.RED);

                Raylib.DrawText($"Points:{points} Life:{life} Time:{((int)time)}", 10, 10, 20, Color.GREEN);
                
                Raylib.EndDrawing();
                //----------------------------------------------------------------------------------
            }
        }
    }
}

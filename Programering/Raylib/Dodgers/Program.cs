using System;
using Raylib_cs;

namespace Dodgers
{
    class Program
    {

        static int fönsterB = 800;
        static int fönsterH = 600;

        static Random generator = new Random();
        static Rectangle coin = new Rectangle(generator.Next(0, fönsterB - 50), generator.Next(-150, -50), 50, 50);
        static Rectangle player = new Rectangle(100, fönsterH - 50, 200, 25);
        static Rectangle enemy = new Rectangle(generator.Next(0, fönsterB - 50), generator.Next(-150, -50), 50, 50);

        static void Main(string[] args)
        {
            // Initialisering
            //--------------------------------------------------------------------------------------

            Raylib.InitWindow(fönsterB, fönsterH, "Snöflingor");
            Raylib.SetTargetFPS(60);

            // TODO: Infoga variabler och objekt här

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
                Speed(time, speedTime, speed);
                //Input
                Input();
                //Kollision
                Kollision(ref points, ref life);
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

        static void Input()
        {
            if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT) || Raylib.IsKeyDown(KeyboardKey.KEY_D))
            {
                if (player.x < fönsterB - 200)
                {
                    player.x += 5;
                }
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT) || Raylib.IsKeyDown(KeyboardKey.KEY_A))
            {
                if (player.x > 0)
                {
                    player.x -= 5;
                }
            }
        }

        static void Speed(float time, int speedTime, int speed)
        {
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
        }

        static void Kollision(ref int points, ref int life)
        {
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
        }
    }
}

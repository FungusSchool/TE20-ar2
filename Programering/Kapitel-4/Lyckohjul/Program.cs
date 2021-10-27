using System;

namespace Lyckohjul
{
    class Program
    {
        static void Main(string[] args)
        {      
            Console.Clear(); 
            Console.WriteLine("Lyckohjul!");

            //Användaren får 3 försök!      
            for (var i = 3; i > 0; i--)
            {
            // Skapa ett program som ska fungera som ett lyckohjul
            Random generator = new Random();
            
            Console.WriteLine($"Du har {i} försök.");
            
            //När användaren kör programmet får hen välja ett tal från 1 till 10 som hen tror att lyckohjulet kommer att stanna på
            Console.Write("Skriv ett number mellan 1-10: ");
            int gissning = int.Parse(Console.ReadLine());
              
            //Slumpa därefter fram ett tal från 1 till 10 och säg till användaren vilket tal det blev
            int lyckohjul = generator.Next(1, 11);
            Console.WriteLine($"Lyckohjulet hamnade på {lyckohjul}");

            //Berätta också för användaren om hen vann eller förlorade
            if (gissning == lyckohjul)
            {
                Console.WriteLine("Du vann!");
                i = 0;
            }
            else
            {
                Console.WriteLine("Du förlora!");

                if (i > 1)
                {
                    Console.WriteLine("Vänligen förök igen.");
                }
                else
                {
                    Console.WriteLine("Du har slut på försök.");
                }
                
            }

            
            }



        }
    }
}

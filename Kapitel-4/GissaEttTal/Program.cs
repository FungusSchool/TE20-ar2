using System;

namespace GissaEttTal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Spel - gissa ett tal mellan 1 och 100.");

            //Spela flera gånger 
            while ()
            {

                //slumpa fram ett tal
                Random tärning = new Random();
                int slumptal = tärning.Next(1, 101);


                //Upprepa frågan
                int räknare = 0;
                while (true)
                {
                    //Räkna upp antal gissningar 
                    räknare++;

                    //Fråga användaren om en gissning
                    Console.Write("Gissa ett tal (1-100): ");
                    int gissning = int.Parse(Console.ReadLine());

                    //Är gissningen rätt?
                    if (gissning == slumptal)
                    {
                        Console.WriteLine($"Korrekt! Du gjorde det på {räknare} försök:");
                        break;
                    }

                    //Jämför med slumptal
                    if (gissning < slumptal)
                    {
                        Console.WriteLine("För lågt!");
                    }
                    else
                    {
                        Console.WriteLine("För högt!");
                    }
                }

                Console.Write("Vill du göra ett till försök? ");
                

            }


        }
    }
}

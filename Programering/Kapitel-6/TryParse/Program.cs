using System;

namespace TryParse
{
    class Program
    {
        static void Main(string[] args)
        {

            //Slump generator 
            Random generator = new Random();

            //Slumpa fram ett tal 
            int slumptal = generator.Next(1,101); //mellan 1-100
            int slumptal2 = generator.Next(1,11); //mellan 1.10
            
            //be spelaren att gissa ett tal 

            
            //Försök översätta det inmattade till ett tal
            int gissningTal = 0;
            bool korrekt = false;

            //loop för att tvinga spelaren mata in något korekt
            while (korrekt != true)
            {
                Console.Write("Gissa ett tal (1-100): ");
                string gissning = Console.ReadLine();
                korrekt = int.TryParse(gissning, out gissningTal);
                
            }

            //Var gissning korrekt
            if (gissningTal == slumptal)
            {
                Console.WriteLine("Du gissade rätt!");
            }
            else
            {
                Console.WriteLine("Du gissade fel!");

            }
        }
    }
}

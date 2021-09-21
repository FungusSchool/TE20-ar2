using System;

namespace Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hur gammal är du? ");
            string ålder = Console.ReadLine();
        
            Console.WriteLine($"Du är {ålder} gammal");

            //Convertera string till heltal
            int åldertal = int.Parse(ålder);

            Console.WriteLine($"Du har {20 - åldertal} år kvar till du får gå på systemet");

            Console.Write("Hur mycket väger du? ");
            float vikt = float.Parse(Console.ReadLine()); 

            Console.WriteLine($"Din vikt i lbs är {vikt * 2.2} ");

            float viktLbs = (vikt * 2.2f); 

            //Formatera till en snygg utskrift.
            string viktString = viktLbs.ToString("0.##");

            Console.WriteLine($"Din vikt är {viktString} lbs");   


        }
    }
}

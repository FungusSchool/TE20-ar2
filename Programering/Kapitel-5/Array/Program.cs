using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Använda array");

            //Skapa en array för 3 öar
            string[] öar = new string[3];
            //första platsen (0)
            öar[0] = "Syros";
            öar[1] = "naxos";
            öar[2] = "kreta";

            //byt ut innehållet 
            öar[0] = "amorgos";

            //Skriv ut innehållet.
            Console.WriteLine(öar[0]);
            Console.WriteLine($"Två andra öar är {öar[1]} och {öar[2]}");
        }
    }
}

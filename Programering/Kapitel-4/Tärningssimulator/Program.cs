using System;

namespace Tärningssimulator
{
    class Program
    {
        static void Main(string[] args)
        {            
            //Skapa ett program som ska fungera som en tärningssimulator

            Random generator = new Random();

            Console.WriteLine("Tärnings simulator!");
    
            //När användaren startar programmet ska hen få säga hur många tärningar hen vill kasta och hur många sidor varje tärning ska ha
            Console.Write("Hur många tärninga vill du ha? ");
            int tärningmängd = int.Parse(Console.ReadLine());

            Console.Write("Hur många sidor ska tärningarna ha? ");
            int tärningssidor = int.Parse(Console.ReadLine());
            
            //Simulera därefter det antal tärningskast som användaren vill göra med det antal sidor som användaren valde
            for (int i = 1; i <= tärningmängd; i++)
            {
                int tärningResultat = generator.Next(1,tärningssidor+1);
            
                //Skriv ut värdet av varje tärningskast
                Console.WriteLine($"Tärning {i} blev {tärningResultat}");
            }
            

        }
    }
}

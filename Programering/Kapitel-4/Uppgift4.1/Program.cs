using System;

namespace Uppgift4._1
{
    class Program
    {
        static void Main(string[] args)
        {

            string land = string.Empty;

            Console.Write("Vilket är världens folkrikaste land? ");
            land = Console.ReadLine().ToLower();
            
            while (land != "china")
            {
                Console.Write("Fel svar gärna försök igen: ");
                land = Console.ReadLine().ToLower();
                
            }
            Console.WriteLine("Bra rätt svar!");
        }
    }
}

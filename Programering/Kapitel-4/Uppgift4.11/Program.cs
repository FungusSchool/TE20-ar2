using System;

namespace Uppgift4._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vilket är världens folkrikaste land? ");
            string land = Console.ReadLine().ToLower();

            int i = 5;

            while (true)
            {
                i--;

                if (land == "china" || i == 0)
                {
                    break;
                }

                Console.WriteLine($"Fels svar du har {i} försök kvar.");
                Console.Write("Gärna försök igen: ");
                land = Console.ReadLine().ToLower();
                
            } 
            if (land == "china")
            {
                Console.WriteLine("Korekt svar bra jobbat!");
            }
            else
            {
                Console.WriteLine("Du fick slut på försök!");
            }

        }
    }
}

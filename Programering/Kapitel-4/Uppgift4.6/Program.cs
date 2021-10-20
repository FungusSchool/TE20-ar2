using System;

namespace Uppgift4._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Förklara programet
            Console.WriteLine("Gör om ett meddelande till vertikalt baklänges");
        
            Console.Write("Skriv ett meddelande: ");
            string meddelande = Console.ReadLine();
            
            for (int i = meddelande.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(meddelande[i]);
            }
        
        }
    }
}

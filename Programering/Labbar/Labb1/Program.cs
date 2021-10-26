using System;

namespace Labb1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Presentera programmet
            Console.WriteLine("Program som skriver ut ASCII");

            // Be användaren mata in ett meddelande
            Console.Write("Ange ett ord: ");
            string meddelande = Console.ReadLine();

            //Fråga användaren om en nyckel
            Console.Write("Ange en nyckel (1-9): ");
            int nyckel = int.Parse(Console.ReadLine());

            //Skapa en variablen för den färdiga meddelandet 
            string meddelandeKrypterad = "";

            // Loopa igenom ordet bokstav-för-bokstav
            for (int i = 0; i < meddelande.Length; i++)
            {
                //Skapa variablar för koksäver och ASCII koden till dom
                char bokstav = meddelande[i];
                int kod = (int)bokstav;
                
                // Lägg till nyckeln
                int nyKod = kod + nyckel;

                if (nyKod > 90)
                {
                    nyKod = (nyKod - 91) + 97;
                }

                // Tecken av ASCII-kod
                char bokstavKrypterad = (char)(kod);

                char bokstavKrypterad1 = (char)(nyKod);
               
                //Sätt ihop boktäverna till ett medelande
                meddelandeKrypterad += bokstavKrypterad.ToString();

                Console.WriteLine($"{bokstavKrypterad} {bokstavKrypterad1}");
            }
                Console.WriteLine($"{meddelande} blir till {meddelandeKrypterad}");
        }
    }
}

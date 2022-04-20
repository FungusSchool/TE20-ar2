using System;

namespace prov3b_genomgång
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Program for listing countries!");

            // Array of country names
            string[] countries = {
                "Andorra", "Afghanistan", "Antigua och Barbuda", "Bulgarien", "Vitryssland", "Benin", "Chile", "Kina", "Dominikanska republiken", "Eritrea", "Indonesien", "Kirgizistan", "Liechtenstein", "Madagaskar", "Papua Nya Guinea"
            };

            //maxlenght for names to output
            int maxLength = 0;

            //Users inputs maxLength 
            maxLength = SafeInts("Please input max length: ");

            //Output all countries
            foreach (var country in countries)
            {
                if (country.Length <= maxLength)
                {
                    Console.WriteLine(country);
                }
            }
        }

        static int SafeInts(string text) // skapar funktionen Säkratal
        {
            int tal; // skapar int tal
            Console.Write(text);
            while (!(int.TryParse(Console.ReadLine(), out tal))) // Tar vad användaren skriver och försöker göra det till en int, loopen fortsätter så länge det inte går att omvandla till int
            {
                Console.WriteLine("Ett fel uppstod försök igen");
            }
            return tal; // ger tal som svar på funktionen
        }
    }
}

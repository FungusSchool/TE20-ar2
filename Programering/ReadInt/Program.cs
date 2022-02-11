using System;

namespace ReadInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ange ett tal: ");
            int tal1, helTal;
            while (int.TryParse(Console.ReadLine(), out helTal) == false)
            {
                Console.Write("Du skerv inte ett heltal: ");
            }
            tal1 = helTal;

            Säkraheltal("skriv ett heltal: ");
        }

        static int Säkraheltal(string text) // skapar funktionen Säkratal
            {
                int tal; // skapar int tal
                Console.Write(text);
                while (!(int.TryParse(Console.ReadLine(), out tal))) // Tar vad användaren skriver och försöker göra det till en int, loopen fortsätter så länge det inte går att omvandla till int
                {
                    Console.WriteLine("Ett fel uppstod försök igen: ");
                }
                return tal; // ger tal som svar på funktionen
            }
    }
}

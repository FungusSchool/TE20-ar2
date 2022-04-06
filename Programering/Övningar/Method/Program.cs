using System;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] choices = {"Hej", "Hallo", "Si"};

            GetChoice(choices); 

        }

        static void GetChoice(string[] choices)
        {
            
            for (int i = 0; i < choices.Length; i++)
            {
                Console.WriteLine(choices[i] + (i+1));
            }

            bool correct = false;
            while (correct == false)
            {
               int choice = SafeInts("Chose one: ");
               
               //Fungerar inte här
                if (choice <= choices.Length+1 && choice < 0)
                {
                    correct = true;
                }
                else
                {
                  Console.WriteLine("Not a choice try again.");  
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

using System;

namespace Uppgfit1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Den här kommer skriver den raden text i consolen.
            Console.WriteLine("Du är nästan klar med kapitel 1.");

            //med Hjälp av \ så kan man skriva utt tecken som annars används i koden.
            Console.WriteLine("Du har lärt dig skriva ut tecken som \" och \\.");

            //Gör så att Terminal inte direkt stängs ner utan väntar på input från tengetbordet.
            Console.ReadKey();
        }
    }
}

using System;

namespace Övning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Läser in ett namn! ");
            string namn = Console.ReadLine();
            Console.WriteLine("hej där " + namn);

            Console.Write("Vart bor du? " );
            string hem = Console.ReadLine();
            Console.WriteLine("Varför vid " + hem);

            Console.Write("Din ålder?");
            string ålder = Console.ReadLine();
            Console.WriteLine($"Du är {ålder} nu");
        }
    }
}

using System;

namespace LuckText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name one place: ");
            string place = Console.ReadLine();
            
            Console.Write("Name one item: ");
            string item = Console.ReadLine();
            
            Console.Write("Name one person: ");
            string victim = Console.ReadLine();

            Console.Write("Second place: ");
            string body = Console.ReadLine();
            
            Console.Write("Second person: ");
            string witness = Console.ReadLine();

            Console.Write("Verb: ");
            string witnessVerb = Console.ReadLine();
            
            Console.Write("Second verb: ");
            string yourVerb = Console.ReadLine();
            


            Console.WriteLine($"You have just killed {victim} at {place} with (a) {item} and hid there body in {body}");
            Console.WriteLine($"But {witness} ses you and {witnessVerb} in suprise!");
            Console.WriteLine($"{witness} tries to run but you {yourVerb} so they stop. ");


            Console.ReadKey();
            
        }
    }
}

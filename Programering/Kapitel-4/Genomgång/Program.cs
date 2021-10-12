using System;

namespace Genomgång
{
    class Program
    {
        static void Main(string[] args)
        {
            string inmatat = string.Empty;
            while (inmatat != "Sluta" )
            {
                Console.Write("Mata in något: ");
                inmatat = Console.ReadLine();
                
                Console.WriteLine("Du skrev: " + inmatat);
            }
        }
    }
}

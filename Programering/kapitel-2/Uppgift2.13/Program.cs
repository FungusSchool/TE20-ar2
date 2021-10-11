using System;

namespace Uppgift2._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Vad är lönen för person 1? ");
            int lön1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Vad är lönen för person 2? ");
            int lön2 = int.Parse(Console.ReadLine());  
        
            Console.WriteLine($"Vad är lönen för person 3? ");
            int lön3 = int.Parse(Console.ReadLine());

            //Räkan ut medellönen           
            float medellön = ((lön1 + lön2 + lön3)/3);
            Console.WriteLine($"Då är medellönen för dom tre personerna {medellön}");

        }
    }
}

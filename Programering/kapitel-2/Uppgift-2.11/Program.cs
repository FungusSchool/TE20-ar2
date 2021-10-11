using System;

namespace Uppgift_2._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hur många dar vill du hyra bilen för? ");
            int dar = int.Parse(Console.ReadLine());

            Console.Write("Hur många kilometer ska du köra? ");
            int kilometer = int.Parse(Console.ReadLine());

            Console.WriteLine($"Då kommer det kosta {300 + (dar - 1)*500 + kilometer}kr");

        }
    }
}

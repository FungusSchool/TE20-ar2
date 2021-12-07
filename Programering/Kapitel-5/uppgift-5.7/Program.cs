using System;

namespace uppgift_5._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] tal = {5, 4, 3, 2, 1};
            int summan = 0;

            //breräkna summan avv alla heltal 
            foreach (var siffra in tal)
            {
                summan += siffra;
            }
            Console.WriteLine(summan);
        }
    }
}

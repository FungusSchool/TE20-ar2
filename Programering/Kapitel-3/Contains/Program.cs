using System;

namespace Contains
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in din epost: ");
            string epost = Console.ReadLine();

            if (epost.Contains("@"))
            {
                Console.WriteLine("Dyu har en giltig epost");
            }

            Console.WriteLine("Mata in ett mattetal: ");
            string matteTal = Console.ReadLine();

            //berätta om tallet inehåller + - / *
            bool flagga = false;
            if (matteTal.Contains("+"))
            {
                Console.WriteLine("Du använder operator +");
                flagga = true;
            }
            if (matteTal.Contains("-"))
            {
                Console.WriteLine("Du använder operator -");
                flagga = true;

            }
            if (matteTal.Contains("/"))
            {
                Console.WriteLine("Du använder operator /");
                flagga = true;

            }
            if (matteTal.Contains("*"))
            {
                Console.WriteLine("Du använder operator *");
                flagga = true;

            }

            if (!flagga)
            {
                Console.WriteLine("Du använder inte någin av +, -, *, /");
            }
        }
    }
}

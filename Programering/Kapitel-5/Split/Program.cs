using System;

namespace Split
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Räkna ord");

            Console.Write("Ange en mening: ");
            string mening = Console.ReadLine();
            
            //Dela upp meningen för att hitta alla ord
            string[] orden = mening.Split(' ');
            //Skriv ut alla ord på varsin rad 
            foreach (var ord in orden)
            {
                Console.WriteLine(ord);
            }

            int summa = 0;
            foreach (var ord in orden)
            {
                summa ++;
            }
            Console.WriteLine(summa);
            Console.WriteLine($"Antal ord i en mening är {orden.Length}");

            //Sätt samman en ny mening 
            string nymening = string.Join('/', orden);

             Console.WriteLine(nymening);
        }
    }
}

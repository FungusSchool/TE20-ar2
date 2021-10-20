using System;

namespace Uppgift4._7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skriv din summa, tex 537
            Console.Write("Skriv din summa ");
            string summaText = Console.ReadLine();
            
            //Loopa igenom summaText
            int summa = 0;
            for (int i = 0; i < summaText.Length; i++)
            {
                char siffra = summaText[i];
                Console.WriteLine(siffra);
            
                //Omvalda char -> string -> int           
                //Omvandla char med .ToString   
                int siffraTal = int.Parse(siffra.ToString());

                //Addera till summan
                summa += siffraTal;
            }

            Console.WriteLine(summa);

        }
    }
}

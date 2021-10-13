using System;

namespace MenyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enkelt menyprogram!");

            //Skapa en slumgenerator
            Random tärning = new.Random();


            //Programloopen
            while (true)
            {
                //Slumpa fram ett tal
                int slumptal = tärning.Next(1, 4);

                Console.WriteLine("Välj ett av följande alternativ? ");
                Console.WriteLine("Väljer du sten? (1)");
                Console.WriteLine("Väljer du sax? (2)");
                Console.WriteLine("Väljer du påse? (3)");
                Console.WriteLine("Vill du avsluta? (4)");
                string valString = Console.ReadLine();

                //Vill användaren avsluta?
                if (valString == "4")
                {
                    break;
                }

                //Omvandla till en int för slumptal är en int
                int valInt = int.Parse(valString);

                //Är det rätt svar
                if (valInt == 1 && slumptal == 1)
                {
                    Console.WriteLine("Oavgjort!");
                }
                else if (valInt == 2 && slumptal == 1)
                {
                    Console.WriteLine("Du förlora!");
                }
                else if (valInt == 3 && slumptal == 1)
                {
                    Console.WriteLine("Du vinner!");
                }
                else if (valInt == 1 && slumptal == 2)
                {
                    Console.WriteLine("Du vinner!");
                }
                else if (valInt == 2 && slumptal == 2)
                {
                    Console.WriteLine("Oavgjort!");
                }
                else if (valInt == 3 && slumptal == 2)
                {
                    Console.WriteLine("Du förlora!");
                }
                else if (valInt == 1 && slumptal == 3)
                {
                    Console.WriteLine("Du förlora!");
                }
                else if (valInt == 2 && slumptal == 3)
                {
                    Console.WriteLine("Du vinner!");
                }
                else if (valInt == 3 && slumptal == 3)
                {
                    Console.WriteLine("Oavgjort!");
                }


            }
        }
    }
}

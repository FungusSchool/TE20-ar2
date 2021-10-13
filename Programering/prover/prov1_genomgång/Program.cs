using System;

namespace prov1_genomgång
{
    class Program
    {
        static void Main(string[] args)
        {
            // berätta vad programet gör
            Console.WriteLine("Uträkning av nettolön \n---------------------");

            //upprepa 
            while (true)
            {

                // Fråga efter namn
                Console.Write("Vad heter du? ");
                string namn = Console.ReadLine();

                //Fråga efter bruttolön
                Console.Write("Ange din bruttolön i kronor: ");
                int bruttolön = int.Parse(Console.ReadLine());

                //Kolla att villkoren är uppfyllda för bruttolön
                if (bruttolön >= 10000 && bruttolön < 45000)
                {
                    //Fråga efter skattesats
                    Console.Write("Ange din skattesats i procent: ");
                    int skattesatsen = int.Parse(Console.ReadLine());

                    //Kolla att villkoren är uppfyllda för skattesats
                    if (skattesatsen > 10 && skattesatsen < 45)
                    {
                        //Räkna ut nettolön
                        int nettolön = bruttolön * (100 - skattesatsen) / 100;

                        Console.WriteLine($"{namn}, din lön efter skatt är {nettolön}");

                    }
                    else
                    {
                        Console.WriteLine("Skaatesats måste vara mellan 10 och 450");
                    }

                }
                else
                {
                    Console.WriteLine("Bruttolön måste vara mellan 10000 och 45000");
                }

                //Vill du köra igen
                Console.Write("Vill du köra igen?(j/n) ");
                string svar = Console.ReadLine();
                
                if (svar == "n") // (svar != "j")
                {
                    break;
                }

            }


        }
    }
}

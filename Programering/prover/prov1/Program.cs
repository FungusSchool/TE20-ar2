using System;

namespace prov1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tömer konsolen 
            Console.Clear();

            //sätter det i en loop så att man kan köra pogramet igen.
            while (true)
            {


                //Säga vad programet är för nåt
                Console.WriteLine("Uträkning av nettolön");
                Console.WriteLine("---------------------");

                //Fråga användares namn och läsa in det
                Console.Write("Vad heter du? ");
                string namn = Console.ReadLine();

                //Fråga om deras bruttolön och gör om det till en int
                Console.Write("Ange din bruttolön i kronor: ");
                int bruttolön = int.Parse(Console.ReadLine());

                //Kollar så bruttolönen är inom rätt mängd
                if (bruttolön < 10000 || bruttolön > 45000)
                {
                    //gör en rad för att vissa en bryting i texten
                    Console.WriteLine("---------------------");
                    //Ändra text färgen till rött
                    Console.ForegroundColor = ConsoleColor.Red;
                    //Säg till dom att dom har anget fel bruttolön
                    Console.WriteLine($"{namn}, bruttolön måste vara mellan 10000 kr och 45000kr! ");
                    //ändra tillbaka färgen till vitt och be dom försöka igen
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Vänligen försök igen.");

                }
                else
                {
                    //fråga dom om deras skattesats och gör om det till en int.
                    Console.Write("Ange din skattesats i %: ");
                    int skattesats = int.Parse(Console.ReadLine());

                    if (skattesats < 10 || skattesats > 45)
                    {
                        //gör en rad för att vissa en bryting i texten
                        Console.WriteLine("---------------------");
                        //Ändra text färgen till rött
                        Console.ForegroundColor = ConsoleColor.Red;
                        //Säg till dom att dom har anget fel skattesats
                        Console.WriteLine($"{namn}, skattesatsen måste vara mellan 10% och 45%! ");
                        //ändra tillbaka färgen till vitt och be dom försöka igen
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Vänligen försök igen.");
                    }
                    else
                    {
                        //Beräkna netolönen
                        int nettolön = bruttolön * (100 - skattesats) / 100;

                        //Linje brytning
                        Console.WriteLine("---------------------");
                        //berätta för användaren deras netto lön.
                        Console.WriteLine($"{namn}, din nettolön blir {nettolön} kr.");
                        Console.WriteLine($"Baserat på bruttolön {bruttolön} kr och skattesatsen {skattesats}%.");
                    }
                }

                //Frågar användare om dom vill göra en ny beräkning och gör om deras svar till små bokstäver
                Console.Write("Vill du köra igen?(ja/nej) ");
                string köraIgen = Console.ReadLine().ToLower();

                //Kollar om dom ville köra igen om inte så stängs pogramet.
                if (köraIgen == "nej")
                {
                    break;
                }
            }
        }
    }
}

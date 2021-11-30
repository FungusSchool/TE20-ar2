using System;

namespace TP_frågor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Slumoa fram en fråga!");

            //Namnge korten (array)
            string [] korten = {
                "När uppfördes Verdi?",                 //0
                "Vem van fotbolls-EM 1984",             //1
                "Vem skrev frankenstein?",              //2
                "Vad är 5+5?",                          //3
                "När stardade andra världs kriget?",    //4
                "Vem är president i USA 2021?"          //5
                };

            //kasta träningen 
            Random tärning = new Random();
            int slumptal = tärning.Next(0, 6);  //0 till 5 

            //skriver utslaget
            Console.WriteLine($"Tärningen slog {slumptal}");

            //Skriv ut fråga 
            Console.WriteLine($"Frågan: {korten[slumptal]}");
        }
    }
}

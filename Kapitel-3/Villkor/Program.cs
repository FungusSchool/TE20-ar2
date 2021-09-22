using System;

namespace Villkor
{
    class Program
    {
        static void Main(string[] args)
        {

            //Frågar om ålder
            Console.Write("Hur gammal är du? (Heltal) ");
            int Ålder = int.Parse(Console.ReadLine()); 

            //om ålder är större än 18 "Du får ta körkort"
            if (Ålder >= 18)
            {
                Console.WriteLine("Du får ta körkort!");
            }

            //Om du är 15 eller äldre = "Du får ta moped körkort!"
            if (Ålder >= 15)
            {
             Console.WriteLine("Du får ta moped körkort!");  
            }

            //Fråga användare "Vad heter ABBAs senaste låt?
            Console.Write("Vad heter ABBAs senaste Album? ");
            string album = Console.ReadLine();
            
            //Är svaret korrekt
            if (album == "Voyage")
            {
                Console.WriteLine("Rätt svar!");
            }
            else
            {
                Console.WriteLine("Fel svar! Det heter Voyage");
            }

            //Sista TP-frågan 
            Console.Write("Vem missade straffen i matchen England-Frankrike? (efternamn) ");
            //läs in och gör om till små bokstäver.
            //Mbappe -> mbappe 
            //mBappE -> mbappe
            string spelare = Console.ReadLine().ToLower();
            
            if (spelare == "mbappe")
            {
                Console.WriteLine("Rätt svar!");
            }
            else
            {
                Console.WriteLine("Fel svar! Det var Mbappe");
            }

        }
    }
}

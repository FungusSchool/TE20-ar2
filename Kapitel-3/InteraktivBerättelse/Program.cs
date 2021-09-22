using System.Linq.Expressions;
using System;

namespace InteraktivBerättelse
{
    class Program
    {
        static void Main(string[] args)
        {
            // frågar om dom vill spela spelet
            Console.WriteLine("Hej vill du spela spelet? ja eller nej");
            string spela = Console.ReadLine().ToLower();

            // Om dom säger Ja så fortsätter spelet annars avslutar det
            if (spela == "ja") 
            {
                Console.WriteLine("Vad bra forsätt då!");

                // Frågar om vilket håll dom vill gå och gör om det till små bokstäver,
                Console.WriteLine("Vill du gå höger, vänster eller framåt");
                string direction = Console.ReadLine().ToLower();
                
                // Vilket håll dom går bästemer vad som händer sen
                if (direction == "höger")
                {
                    Console.WriteLine("Du svänger höger och börjar gå men ramlar i ett hål och dör av falet.");
                    Console.WriteLine("GAME OVER!");

                } else if (direction == "vänster")
                {
                    Console.WriteLine("Du svänger vänster och börja gå framåt. Du ser en hamburgare på marken.");
                    Console.WriteLine("Vill du ta upp och äta den eller forsätta framåt? (Skriv Ät eller Gå)");
                    string hamburgare = Console.ReadLine().ToLower();
                    
                    if (hamburgare == "ät")
                    {
                        Console.WriteLine("Du äter hamburgaren men börjar få ont i magen.");
                    }
                    else
                    {
                        
                    }
   
                } else if (direction =="framåt")
                {

                }
                //Om dom inte skriver nån av vallen så slutar programet med den texten. 
                else 
                {
                    Console.WriteLine("Så kan du inte göra!");
                }

                
            } else 
            {

                Console.WriteLine("Synd varför startade du ens programet men okej.");
                
            }
            
            
            //väntar på ett input så inte fönstre stängs ner
            Console.WriteLine("Tryck på valfri kanpp för att stänga programet!");
            Console.ReadKey();
            
            
        }
    }
}

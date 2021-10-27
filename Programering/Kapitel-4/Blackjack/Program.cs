using System;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            Console.WriteLine("BlackJack!");

            int dealersNumber = 0;
            int playersNumber = 0;
            
            int dealersFirst = generator.Next(1,11);
            dealersNumber += dealersFirst;

            Console.WriteLine($"Dealers first card is {dealersFirst}");

            int playersFirst = generator.Next(1,11);
            int playersSecond = generator.Next(1,11);
            playersNumber += playersFirst;
            playersNumber += playersSecond;

            Console.WriteLine($"Your first car is {playersFirst} and your second card is {}");
            
            
            while (true)
            {
                 
            }
            // Både du och datorn får poäng genom att dra kort, varje kort är värt 1 – 10 poäng
            // När spelet börjar dras två kort till både dig och datorn
            // Varje omgång dras 1 kort till dig och till datorn
            // Du vinner om datorn får 21 eller mer
            // När du inte vill dra fler kort så kommer datorn att dra kort

        }
    }
}

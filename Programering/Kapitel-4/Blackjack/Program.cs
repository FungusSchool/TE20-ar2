using System;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            Console.WriteLine("BlackJack!");

            int playing = 1;
            while (playing == 1)
            {


                int dealersNumber = 0;
                int playersNumber = 0;

                int dealersFirst = generator.Next(1, 11);
                dealersNumber += dealersFirst;

                Console.WriteLine($"Dealers first card is {dealersFirst}");

                int playersFirst = generator.Next(1, 11);
                int playersSecond = generator.Next(1, 11);
                playersNumber += playersFirst;
                playersNumber += playersSecond;

                Console.WriteLine($"Your first car is {playersFirst} and your second card is {playersSecond}. Your total is now {playersNumber}.");

                //Players turn
                int playersTurn = 1;
                while (playersNumber < 21 && playersTurn == 1)
                {
                    Console.Write("Do you want to stand or hit(draw a card)? ");
                    string playersChoice = Console.ReadLine().ToLower();

                    if (playersChoice == "hit")
                    {
                        int playersNewCard = generator.Next(1, 11);
                        playersNumber += playersNewCard;
                        Console.WriteLine($"Your new car is {playersNewCard} so your total is {playersNumber}.");
                    }
                    else
                    {
                        playersTurn = 0;
                    }
                }
                if (playersNumber > 21)
                {
                    Console.WriteLine("You have gone bust and have lost.");
                }
                else
                {
                    //Dealers Turn
                    int dealersSecond = generator.Next(1, 11);
                    dealersNumber += dealersSecond;
                    Console.WriteLine($"The dealers second car is {dealersSecond} so there total is now {dealersNumber}.");

                    int dealersTurn = 1;
                    while (dealersNumber < 21 && dealersTurn == 1)
                    {
                        if (dealersNumber < 17)
                        {
                            int dealersNewCard = generator.Next(1, 11);
                            dealersNumber += dealersNewCard;
                            Console.WriteLine($"The dealer takes a new card and its {dealersNewCard} so there total is now {dealersNumber}.");
                        }
                        else
                        {
                            dealersTurn = 0;
                        }
                    }

                    if (dealersNumber > 21)
                    {
                        Console.WriteLine("The dealer has gone bust and you have won.");
                    }
                    else if (dealersNumber > playersNumber)
                    {
                        Console.WriteLine("The dealer is higer then you so you have lost");
                    }
                    else if (playersNumber > dealersNumber)
                    {
                        Console.WriteLine("Congrats your number is higer then the dealers so yo have won!");
                    }
                    else
                    {
                        Console.WriteLine("You and the dealer have the same amount so it is a draw.");
                    }

                }

                Console.Write("Do you want to play again(yes/no)?  ");
                string playerAnswer = Console.ReadLine().ToLower();

                if (playerAnswer == "no")
                {
                    playing = 0;
                }
            }

            // Både du och datorn får poäng genom att dra kort, varje kort är värt 1 – 10 poäng
            // När spelet börjar dras två kort till både dig och datorn
            // Varje omgång dras 1 kort till dig och till datorn
            // Du vinner om datorn får 21 eller mer
            // När du inte vill dra fler kort så kommer datorn att dra kort

        }
    }
}

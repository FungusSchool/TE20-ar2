using System;

namespace uppgift_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("uppgift 5,1");
            string[] Städer = new string[3];
            Städer[0] = "stockholm";
            Städer[1] = "göteborg";
            Console.Write($"Skriv en svensk stad som inte är {Städer[1]} {Städer[0]}: ");
            Städer[2] = Console.ReadLine();
            Console.WriteLine($"Städerna är {Städer[0]}, {Städer[1]} och {Städer[2]}");

            //ett annat sätt att skapa en array
            string[] länder = {"Svergie", "Finland", "Danmark", "Norge"};
            länder[0] = "Tyskland";

            //skriv ut alla länder 
            foreach (var land in länder)
            {
                Console.WriteLine(land);
            }
        }
    }
}

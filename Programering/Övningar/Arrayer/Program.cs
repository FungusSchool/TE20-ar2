using System.Collections.Generic;
using System;

namespace Arrayer
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] leksaker = {"ps1", "ps2", "ps3", "ps4", "Vr"};
            String[] namn = {"natan", "mikael", "Benjamin", "måns", "gustav"};
            int[] tal = {2, 4, 6, 8, 10};
            for (int i = 0; i < leksaker.Length; i++)
            {
                Console.WriteLine($"{namn[i]} ger {leksaker[i]} betyget {tal[i]}");
            }

            List<string> cities = new List<string>();
            bool exit = false;
            while (exit == false)
            {
                Console.WriteLine("Write a city or typ exit to end:");
                string playerInput = Console.ReadLine();
                if (playerInput == "exit")
                {
                    exit = true;
                }
                else
                {
                    cities.Add(playerInput);
                }
            }
            int citiesLength = cities.Count;
            for (int i = 0; i < citiesLength; i++)
            {
                Console.WriteLine(cities[i]);
            }

        }
    }
}

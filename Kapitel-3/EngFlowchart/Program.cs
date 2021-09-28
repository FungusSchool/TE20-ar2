using System;
using System.Text;

namespace EngFlowchart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Clear();
            Console.WriteLine("Engineering Flowchart");

            Console.Write("Does it move? (yes/no) ");
            string answer1 = Console.ReadLine();
            
            if (answer1 == "yes")
            {
                Console.Write("Should it? (yes/no) ");
                string answer2 = Console.ReadLine();
                if (answer2 == "yes" )
                {
                    Console.WriteLine("No problem! 😃");
                }
                else
                {
                    Console.WriteLine("Use Duct Tape!   ");
                }
            }
            else
            {
                Console.Write("Should it? (yes/no)  ");
                string answer3 = Console.ReadLine();
                
                if (answer3 == "yes" )
                {
                    Console.WriteLine("use WD-40! ");
                }
                else
                {
                    Console.WriteLine("No problem! 😃");
                }
            }

        }
    }
}

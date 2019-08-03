using System;

namespace Demonstar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1: NEW GAME");
            Level1 lvl1 = new Level1();
            lvl1.StartLevel(1);

            Console.WriteLine("2: CONTINUE");
            // read save game from file and start that level


            Console.WriteLine("3: HIGH SCORE");
            Console.WriteLine("4: EXIT");
           // int choice = Console.ReadLine();


        }
    }
}

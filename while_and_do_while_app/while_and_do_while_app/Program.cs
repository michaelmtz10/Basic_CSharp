using System;

namespace while_and_do_while_app
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Guess which nfl team is the best!");
            Console.ReadLine();
            string team = "cowboys";
            string guess = "";
            while (guess != team)
            {
                Console.WriteLine("Guess again!");
                guess = Console.ReadLine();
                
            }
            Console.WriteLine("That is correct!");
            {
                int num = 100;

                do
                {
                    Console.WriteLine("value of number: {0}", num);
                    num = num + 1;
                }
                while (num < 20);
                Console.ReadLine();
            }
        }
    }
}

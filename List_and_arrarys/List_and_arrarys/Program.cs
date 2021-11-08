using System;
using System.Collections.Generic;

namespace List_and_arrarys
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] brands = { "nike", "jordan", "adidas" };
            Console.WriteLine("pick a number less than 3, including zero");
            int answer = Int32.Parse(Console.ReadLine());
            if (answer == 0)
            {
                Console.WriteLine(brands[0]);
            }
            else if (answer == 1)
            {
                Console.WriteLine(brands[1]);
            }
            else if (answer == 2)
            {
                Console.WriteLine(brands[2]);
            }
            else if (answer < 2)
            {
                Console.WriteLine("Number option does not exist");
            }
            else
            {
                Console.WriteLine("number is out of range");
            }

            int[] amounts = { 10, 20, 30, 40, 50, 60 };
            Console.WriteLine("Select a number less than 5, also including 0.");
            int response = Int32.Parse(Console.ReadLine());
            if (response == 0)
            {
                Console.WriteLine(amounts[0]);
            }
            else if (response == 1)
            {
                Console.WriteLine(amounts[1]);
            }
            else if (response == 2)
            {
                Console.WriteLine(amounts[2]);
            }
            else if (response == 3)
            {
                Console.WriteLine(amounts[3]);
            }
            else if (response == 4)
            {
                Console.WriteLine(amounts[4]);
            }
            else if (response == 5)
            {
                Console.WriteLine(amounts[5]);
            }
            else
            {
                Console.WriteLine("The number chosen is out of range or is not a valid input");
            }
          
            List<string> colors = new List<string>() { "red", "blue", "green", "yellow" };
            Console.WriteLine("Pick another number less than 4");
            int pick = Int32.Parse(Console.ReadLine());
            
            if (pick == 0)
            {
                Console.WriteLine(colors[0]);
            }
            else if (pick == 1)
            {
                Console.WriteLine(colors[1]);
            }
            else if (pick == 2)
            {
                Console.WriteLine(colors[2]);
            }
            else if (pick == 3)
            {
                Console.WriteLine(colors[3]);
            }
            else if (pick > 3)
            {
                Console.WriteLine("number is out of reach.");
            }

            List<int> money = new List<int>() { 10000, 20000, 30000, 40000, 50000 };
            Console.WriteLine("Pick a number less than 5, including 0");
            int choice = Int16.Parse(Console.ReadLine());
            if (choice == 0)
            {
                Console.WriteLine(money[0]);
            }
            else if (choice == 2)
            {
                Console.WriteLine(money[1]);
            }
            else if (choice == 3)
            {
                Console.WriteLine(money[2]);
            }
            else if (choice == 4)
            {
                Console.WriteLine(money[3]);
            }
            else if (choice == 4)
            {
                Console.WriteLine(money[4]);
            }
            else if (choice > 4)
            {
                Console.WriteLine("That choice is not valid.");
            }
            else
            {
                Console.WriteLine("Character not number");
            }
            Console.Read();
        }
    }
}

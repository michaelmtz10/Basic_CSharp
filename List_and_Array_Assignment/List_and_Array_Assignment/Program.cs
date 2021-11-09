using System;
using System.Collections.Generic;
using System.Linq;

namespace List_and_Array_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // part 1
            string[] models = new string[3] { "camaro", "mustang", "corolla" }; // created a string with a maximum index of 3
            Console.WriteLine("type anything thats a letter.."); // tells the user to type character
            string intro = Console.ReadLine(); // created var for user input 
            foreach (string model in models) // for every instance perform command
                Console.WriteLine(model + " " + intro);
            // part 2 to infinity

            //int standard = 10;
            //int sky = 11;
            //while (sky > standard)
            //{
            //    Console.WriteLine(sky);
            //    sky++;
            //}
            // part 2 fixed
            Console.WriteLine("type any letter");
            Console.ReadLine();
            Console.WriteLine("type key to see a count to 9");
            Console.ReadLine();
            int standard = 10;
            int sky = 1;
            while (sky < standard) // created while loop to create condtion
            {
                Console.WriteLine(sky);
                sky++;
            }
            // part 3
            Console.WriteLine("Type to see count to 99");
            Console.ReadLine();
            int empty_glass = 1; 
            int full_glass = 100;
            while (empty_glass < full_glass) // created while loop to perform task until condition is met
            {
                Console.WriteLine(empty_glass); // print result until condition is false
                empty_glass++;
            }
            // less than or equal to
            Console.WriteLine("Type to see count to 250");
            Console.ReadLine();
            int qp = 1;
            int goal = 250;
            while (qp <= goal)
            {
                Console.WriteLine(qp);
                qp++;
            }
            // part 4
            var transportation = new List<string>() { "car", "boat", "plane", "bike" }; // created list of string 
            Console.WriteLine("Type a form of transportation see if its in the list!");
            string transpo = Console.ReadLine();

            if (transpo.Contains("car") == true) // conditional loop prints string of given index based on user input
            {
                Console.WriteLine("Its on the list!");
            }
            else if (transpo.Contains("boat") == true)
            {
                Console.WriteLine("Its on the list!");
            }
            else if (transpo.Contains("plane") == true)
            {
                Console.WriteLine("Its on the list!");
            }
            else if (transpo.Contains("bike") == true)
            {
                Console.WriteLine("Its on the list!");
            }
            else
            {
                Console.WriteLine("Not on list."); // if integer not on list, string is printed
            }

            // part 5
            Console.WriteLine("type something you would find in a grocery list");
            string choice = Console.ReadLine(); // use user input to create var
            List<string> groceries = new List<string> { // created a list of groceries
                "milk", "cookies", "chips", "bread", "water", "milk"
            };
            int index = groceries.IndexOf(choice);
            if (index != -1) // if groceries is not equal to number outside of range print, item and index 
            {
                Console.WriteLine("The index for item {0}, is found in position {1}.", choice, index);
            }
            else // print not found if number inputed not in the range of list
            {
                Console.WriteLine("Item is not found on the list!");
            }

            // part 6
            Console.WriteLine("Here is a list of car brands, lets see if any of the names repeat!");
            List<string> car_brands = new List<string>() { "chevy", "subaru", "honda", "toyota", "ford", "dodge", "nissan", "buick", "pontiac", "gmc", "hyundai", "nissan", "ferrari", "lexus" };
            var duplicates = car_brands.GroupBy(brand => brand).Where(g => g.Count() > 1).Select(y => y.Key); // created a variable with a condition stating ifvar is used more than once, group var
            foreach (var car in car_brands)
            {
                Console.WriteLine(car);
            }


            foreach (var d in duplicates) // for every duplicate print duplicate string
            {
                Console.WriteLine(d + " appears twice on this list");
                   
            }
        }
    }
}

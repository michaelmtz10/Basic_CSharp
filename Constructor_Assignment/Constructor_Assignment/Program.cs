using System;

namespace Constructor_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // created constant
            const string myname = "michael";
            // created var
            Console.WriteLine("What is your favorite food item?");
            var choice = Console.ReadLine();

            // concatenating var and const with string
            var output = myname + " favorite food is ... " + choice;
            Console.WriteLine(output);

            // calls default constructor 
            Customer cust1 = new Customer();
            cust1.My_meal();

            Console.Read();
        }
    }
}

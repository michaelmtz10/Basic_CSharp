using System;

namespace Divided_ouput
{
    class Program
    {
        static class Vehicle // created a static class
        {
            public static string make; // created static variables
            public static string model;
            public static int price;
        }
        static void Main(string[] args)
        {
            Vehicle.make = "Toyota"; // assigned the variables
            Vehicle.model = "Tundra";
            Vehicle.price = 54000;
            Console.WriteLine("The Vehicle on sale now is the {0} {1} and, its marked at {2}", Vehicle.make, Vehicle.model, Vehicle.price);
            Console.ReadLine(); // created string and formatted with given variable place holders

            // created a program that will divide user input by 2
            Console.WriteLine("Enter a number, which will undergo an operation."); 
            int divy = Convert.ToInt32(Console.ReadLine());
            // created instance of class
            Divider my_instance = new Divider();
            // called method
            my_instance.Diviser(divy);
            Console.ReadLine();

            // created another instance with a method that outputs parameters
            Automatic options = new Automatic();
            // created vars with pre existing data
            int r = 20;
            int v = 40;

            options.Outputter(out r, out v);
            Console.WriteLine("{0} is half of {1}", r, v); // outputted that data
            Console.ReadLine();

            // ask user to input int
            Console.WriteLine("Enter a number to be multiplied by 100");
            int response = Convert.ToInt32(Console.ReadLine());
            Overloaded super = new Overloaded(); // create instance of class
            int answer = super.Multi_task(response); //created var for method response after execution
            Console.WriteLine(answer);
            Console.ReadLine();

            Console.WriteLine("Enter a price amount to find, what the total cost would be with tax!");
            double initial = Convert.ToDouble(Console.ReadLine());

            Overloaded sales = new Overloaded(); // used same method to create different operation
            double amount = sales.Multi_task(initial); // assign var that'll act as by product
            Console.WriteLine("Total $" + amount); // created string to output result
            Console.ReadLine();

        }
    }
}

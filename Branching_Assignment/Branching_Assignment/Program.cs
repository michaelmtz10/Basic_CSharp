using System;

namespace Branching_Assignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to the Package Express. Please follow the instructions below.");
            Console.WriteLine("What is the weight of your package?");
            double package = Convert.ToDouble(Console.ReadLine());  // convert input into double incase non exact whole number dimension
            double max = 50;
            if (package > max)      // if weight is greater than max then display necessary info, if not ask for next measurement
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("What is the package width?");
            }
            double p_width = Convert.ToDouble(Console.ReadLine());
            if (p_width > max)
            {
                Console.WriteLine("Package is to wide to be shipped by Package Express.");
            }
            else
            {
                Console.WriteLine("What is the package height?");
            }
            double p_height = Convert.ToDouble(Console.ReadLine()); // if weight under max get heigh and convert to double
            if (p_height > max)
            {
                Console.WriteLine("Package is too long to be shipped by Package Express.");
            }
            else
            {
                Console.WriteLine("What is the package length?");
            }
            double p_length = Convert.ToDouble(Console.ReadLine()); // if height less than max get length
            if (p_length > max)
            {
                Console.WriteLine("Your package is to big to be shipped by Package Express.");
            }
            else if (p_height + p_length + p_width > 50) // added all dimensions and if result is grater than 50, program ends if not then else is executed.
            {
                Console.WriteLine("package is too big to be shipped via Package Express.");
            }
            else
            {
                double quote = p_width * p_height * p_length * package / 100; // if all dimensions fall under max, multiply within themselves and divide by 100 to get price.
                Console.WriteLine("The price to ship your package is : ${0}", quote);
                Console.Read();
            }

        }
    }
}

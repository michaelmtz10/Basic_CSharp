using System;

namespace method_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // method overload 1
            Console.WriteLine("Type in a number that will be added");
            int input = Convert.ToInt32(Console.ReadLine());

            overload overload_1 = new overload(); // instance of method is created
            int total = overload_1.the_method(input); // total is the sum of number input plugged into method wih
            Console.WriteLine(total);                  // pre created math operation
            
            // method overload 2
            Console.WriteLine("Type in a decimal number..");
            decimal desi = Convert.ToDecimal(Console.ReadLine()); // converts input to decimal

            overload overload_2 = new overload();
            decimal amount = overload_2.the_method(desi); // amount is created when input given and method is applied
            Console.WriteLine(amount);

            // method overload 3
            Console.WriteLine("Type in the actual word of a valid number..");
            string num = Convert.ToString(Console.ReadLine()); // converts user input to string
            overload overload_3 = new overload(); // new instance of method
            string output = overload_3.the_method(num); // output will equal nethod with method string to int
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}

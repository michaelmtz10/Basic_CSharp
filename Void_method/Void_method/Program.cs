using System;

namespace Void_method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number..");
            int int_1 = Convert.ToInt32(Console.ReadLine()); // ask user to input num which will have math operation

            Console.WriteLine("Enter a second number..");
            int int_2 = Convert.ToInt32(Console.ReadLine()); // ask user num which only render num

            void_method result = new void_method(); // create instance of class void_method
            result.Solver(5, 7); // giving parameters to method

        }
    }
}

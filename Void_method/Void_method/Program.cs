using System;

namespace Void_method
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number");
                int response_1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter a second number..");
                int response_2 = Convert.ToInt32(Console.ReadLine());

                void_method my_instance = new void_method();
                Console.WriteLine(my_instance.Solver(response_1, response_2));
            }
        }
    }
}

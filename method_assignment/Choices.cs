using System;

namespace method_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in a number of choice..");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type in another number if desired.");
            int b = Convert.ToInt32(Console.ReadLine());
            Options(a, b);
            Console.Read();
         
        }

        private static void Options(int a, int b = 80)
        {
             Console.WriteLine("Answer :" + a * b);
        }
    }
}

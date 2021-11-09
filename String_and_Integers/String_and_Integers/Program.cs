using System;
using System.Collections.Generic;

namespace String_and_Integers
{ 
    
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> the_list = new List<int>() { 10, 20, 30, 40, 50, 60 }; // created a list of integers
                Console.WriteLine("Type in number as diviser..");
                int dagger = Convert.ToInt32(Console.ReadLine()); // created variable inplace of user input, which is converted into int
                foreach (int num in the_list) // created loop to iterate through every index
                {
                    Console.WriteLine(num / dagger); // dividing list by input
                }
                Console.ReadLine();
            }
            catch (FormatException non_num) // if response is incorrect format display given string
            {
                Console.WriteLine("Needs to be a number!");
            }
            catch (DivideByZeroException non_zero) // if response is 0, print given string using divisionby zero method
            {
                Console.WriteLine("Can't be divided by 0!");
            }
            finally // regardless of input display string
            {
                Console.WriteLine("Thank you for your participation.");
            }
        }
    }
}

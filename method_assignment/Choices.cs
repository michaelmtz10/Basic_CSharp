﻿using System;

namespace method_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
        try
            {
                Console.WriteLine("Type in a number of choice..");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Type in another number if desired.");
                int b = Convert.ToInt32(Console.ReadLine());

                optional result = new optional();
                int output = result.Options(a, b);
                Console.WriteLine(output);
            }
            catch (FormatException) 
            {
                Console.WriteLine("Input is not valid.");
            }
            Console.Read();
         
        }
    }
}

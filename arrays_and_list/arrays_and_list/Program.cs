using System;
using System.Collections.Generic;

namespace arrays_and_list
{
    class Program
    {
        static void Main()
        {
            string[] brands = { "nike", "jordan", "adidas" };
            Console.WriteLine("pick a number less than 3, including zero");
            int num_0 = Int16.Parse("0");
            int num_1 = Int16.Parse("1");
            int num_2 = Int16.Parse("2");

            if (num_0 == 0)
            {
                Console.WriteLine(brands[0]);
            }
            else if (num_1 == 1)
            {
                Console.WriteLine(brands[1]);
            }
            else if (num_2 == 2)
            {
                Console.WriteLine(brands[2]);
            }
            else
            {
                Console.WriteLine("number is out of range");
            }
            Console.ReadLine();

            //int[] numArray = new int[5];
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[3] = 200;
            //numArray[4] = 5000;

            //int[] numArray1 = new int[] { 5, 2, 10, 200, 4000 };
            //Console.WriteLine("pick a number less than 5");
            //string input = Console.ReadLine();

            //Console.WriteLine(numArray1[]);
            //Console.ReadLine();
        }
    }
}

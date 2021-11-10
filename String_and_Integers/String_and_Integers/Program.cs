using System;
using System.Collections.Generic;

namespace calling_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // calling the first method which will multiply
            Console.WriteLine("Type in a number to multiply.");
            int first = Convert.ToInt32(Console.ReadLine()); // converting response to int

            the_operator multi = new the_operator(); // creating instance of class operator
            int answer = multi.multiplier(first); // creating variable which calls method
            Console.WriteLine("Answer :" + answer); // outputting response with total of input

            // calling the second method which will divide input
            Console.WriteLine("Type in a number to be divided. ");
            int one = Convert.ToInt32(Console.ReadLine()); // converting user input to int

            the_operator divy = new the_operator(); // creating instance of class the_operator
            int feedback = divy.diviser(one); // creating var from method diviser

            Console.WriteLine("Answer : " + feedback); // returning answer created by user input and method

            // calling the third method which adds
            Console.WriteLine("Type in a number which we will add to another number. ");
            int aye = Convert.ToInt32(Console.ReadLine()); // convert user input to int

            the_operator addy= new the_operator(); // creating indstance
            int sum = addy.adder(aye); // variable calls method which will add user input

            Console.WriteLine("Output : " + sum);
            Console.ReadLine();
        }
    }
}

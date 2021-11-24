using System;
using System.Collections.Generic;


namespace Date_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            var now = DateTime.Now; // assign current time to variable
            Console.WriteLine("This is the time right now: {0}", now + "\n\n"); // display current time to console
            Console.WriteLine("Type in a number to add to the current time.");
            int response = Convert.ToInt32(Console.ReadLine());

            DateTime latertime = DateTime.Now.AddHours(response); // created object from datetime class, with method add hours, hours added will be the int typed by user
            Console.WriteLine("This will be the time: {0}, once added by your number", latertime); // writing the operated time to console


        }
        

    }
}

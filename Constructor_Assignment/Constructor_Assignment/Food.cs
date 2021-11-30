using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Assignment
{
    public class Food
    {
        // created class properties
        public string food_name { get; set; }
        public string food_type { get; set; }
        public string food_course { get; set; }

        // created constructor
        public Food(string fname, string ftype, string fcourse)
        {
            food_name = fname;
            food_type = ftype;
            food_course = fcourse;
        }
        // method displays properties
        public virtual void My_meal()
        {
            Console.WriteLine("The meal I'm having today is a " + food_name + " which is a(n) " + food_type + " food, which people eat for "
            + food_course);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Assignment
{
    public class Customer : Food
    {
        public int Id { get; set; }

        // created chained constructor
        public Customer() : this("hamburger", "American", "lunch", 1)
        {

        }
        // constructor for customer class
        public Customer(string fname, string ftype, string fcourse, int cust) : base (fname, ftype, fcourse)
        {
            Id = cust;
        }

        public override void My_meal()
        {
            // outputs given meal and customer id
            base.My_meal();
            Console.WriteLine("Customer meal info: " + Id);
        }
    }
}

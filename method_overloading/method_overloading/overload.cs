using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overloading
{
    class overload
    {
        internal int the_method(int a)
        {
            int total = a + 100;

            return total;
        }
        public decimal the_method(decimal b)
        {
            decimal amount = b * 100;

            return amount;
        }
        public int the_method(string num)
        {
            int num_converted;
            num_converted = Convert.ToInt32(num);

            return num_converted + 5;
        }
    }
}

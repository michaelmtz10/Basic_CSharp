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
        internal decimal the_method(decimal b)
        {
            decimal amount = b * 100;

            return amount;
        }
        internal string the_method(string num)
        {
            int num_converted;
            num_converted = Int32.Parse(num);

            return num;
        }
    }
}

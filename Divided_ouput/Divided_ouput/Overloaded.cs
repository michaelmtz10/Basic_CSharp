using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divided_ouput
{
    class Overloaded // class will contain method overload
    {
        public int Multi_task(int num) // assigning int to this instance
        {
            int total = num * 100; // create operation
            return total; // return result
        }
        public double Multi_task(double desi) // same method, different operation
        {
            double change = desi * 1.0825; // return imaginary sales tax
            return change;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calling_methods
{
    class the_operator{
        internal int multiplier (int a, int b)
        {
            int total = a * b;

            return total;

        }
        internal int diviser (int x, int y)
        {
            int answer = x / y;

            return answer;
        }
        internal int adder (int f, int g)
        {
            int feedback = f + g;

            return feedback;
        }
    }
}

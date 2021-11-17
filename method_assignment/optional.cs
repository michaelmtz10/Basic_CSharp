using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_assignment
{
    class optional
    {
        public void Options(int a)
        {

            Console.WriteLine(a + 40);
        }
        public void Options(int a, int b = 37)
        {
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}

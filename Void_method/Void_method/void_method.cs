using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_method
{
    public class void_method
    {
        public int response_1 { get; set; }
        public int response_2 { get; set; }
        public void Solver(int x, int y)
        {
            response_1 = x;
            response_2 = y;
            
        }
        public int total(int x, int y)
        {
            return x * 44;
        }
    }
}

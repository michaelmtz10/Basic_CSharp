using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_and_objects
{
    interface IQuittable
    {
       
        public void Quit()
        {
            Console.WriteLine(" will no longer participate.");
        }
    }
}

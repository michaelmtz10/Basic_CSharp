using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_and_objects
{
    class Employee : Person, IQuittable
    {
            
        public void Sayname(int iD)
        {
            Console.WriteLine("Name: " + Firstname + " " + Lastname); // ingerited from the person class 
        }
        public void Quit()
        {
            Console.WriteLine(" has been terminated");
        }
    }
}

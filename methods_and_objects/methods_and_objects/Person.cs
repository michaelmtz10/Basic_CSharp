using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_and_objects
{
    class Person
    {
      public string Firstname = "michael"; // assigned properties
      public string Lastname = "jordan";
        public void Sayname()
        {
            Console.WriteLine("Name: " + Firstname + " " + Lastname); // created method within person class, tell console to write persons' full name
        }
    }
}

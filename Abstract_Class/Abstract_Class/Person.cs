using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class Person
    {
        public string firstname; // created attributes
        public string lastname;

        public virtual void Sayname() // created method which will add fname and lname into string
        {
            Console.WriteLine(firstname + lastname);
        }
    }
}

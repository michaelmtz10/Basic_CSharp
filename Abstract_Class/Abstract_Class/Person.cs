using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class Person
    {
        public string firstname;
        public string lastname;

        public virtual void Sayname()
        {
            Console.WriteLine(firstname + lastname);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class Person
    {
<<<<<<< HEAD
        public string firstname; // created attributes
        public string lastname;

        public virtual void Sayname() // created method which will add fname and lname into string
=======
        public string firstname; //created attributes
        public string lastname;

        public virtual void Sayname() // created virtual method to allow for inheritance
>>>>>>> 5b2ca767962234897721dec1c71e625396abe656
        {
            Console.WriteLine(firstname + lastname);
        }
    }
}

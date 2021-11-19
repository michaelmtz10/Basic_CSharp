using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class Employee : Person // inhertited from perosn class 
    {
        public override void Sayname() // overrided inheritance block to allow for method inheritance
        {
            Console.WriteLine(firstname + lastname + "is a team member");
        }
        
    }
}

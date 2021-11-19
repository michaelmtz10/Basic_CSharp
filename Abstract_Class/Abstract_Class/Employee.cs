using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class Employee : Person, IQuitter // adopted Perosn class, and implemented Iquitter "abstract" method
    {
        public override void Sayname() // created method to add string onto initial Person method, which was inherited
        {
            Console.WriteLine(firstname + lastname + "is a team member");
        }
        public void Quit(double payrate) // implemented IQuitter method 
        {
            double amount = payrate * 1.08;
            Console.WriteLine(" but has chosen to walk away.. from his " + amount + " payrate");
        }
        
    }
}

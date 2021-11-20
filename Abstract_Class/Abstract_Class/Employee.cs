using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class Employee : Person
    {
        public int employee_Id // created a iD property that'll be assigned to every employee
        {
            get
            {
                return employee_Id; // grabs property
            }

            set
            {
                employee_Id = value; // sets property to object
            }
        }
        public static bool operator == (Employee employee_1, Employee employee_2) // created operator overloading method
        {
            if (((object)employee_1.employee_Id) == null || ((object)employee_2.employee_Id) == null) // checks to see if employees.id duplicate
                return Object.Equals(employee_1, employee_2); // returns given employee

            return employee_1.Equals(employee_2); // returns bool if emp_1 == emp_2
        }
        public static bool operator !=(Employee employee_1, Employee employee_2) 
        {
            if (((object)employee_1.employee_Id) == null || ((object)employee_2.employee_Id) == null)
                return ! Object.Equals(employee_1, employee_2);

            return ! employee_1.Equals(employee_2); // return false if no emp_1 == emp_2
        }



        public override void Sayname()
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

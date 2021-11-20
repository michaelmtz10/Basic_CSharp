using System;

namespace Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee_1 = new Employee(); // created instance of employee class
         

            employee_1.firstname = "sample "; 
            employee_1.lastname = "student ";
            employee_1.Sayname();
            employee_1.Quit(24.0); // created object implementing the method of the IQuitter interface, and employee attributes

        }
    }
}

using System;

namespace Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            Employee employee_1 = new Employee(); // created instance of employee class
         

            employee_1.firstname = "sample "; 
            employee_1.lastname = "student ";
            employee_1.Sayname();
            employee_1.Quit(24.0); // created object implementing the method of the IQuitter interface, and employee attributes
=======
            Employee employee_1 = new Employee(); // created insance of Employee class

            employee_1.firstname = "sample "; // initiated method from employee class which inherited from Person class
            employee_1.lastname = "student ";
            employee_1.Sayname(); // called method 
>>>>>>> 5b2ca767962234897721dec1c71e625396abe656
        }
    }
}

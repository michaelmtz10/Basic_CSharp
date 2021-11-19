using System;

namespace Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee_1 = new Employee(); // created insance of Employee class

            employee_1.firstname = "sample "; // initiated method from employee class which inherited from Person class
            employee_1.lastname = "student ";
            employee_1.Sayname(); // called method 
        }
    }
}

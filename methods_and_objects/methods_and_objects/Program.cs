
using System;

namespace methods_and_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employees: ");
            Employee employee_1 = new Employee(); // created instance of the employee class
            employee_1.Sayname(); // initialize object
            Console.ReadLine();
        }
    }
}

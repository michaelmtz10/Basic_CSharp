using System;

namespace Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee_1 = new Employee();

            employee_1.firstname = "sample ";
            employee_1.lastname = "student ";
            employee_1.Sayname();
        }
    }
}

using System;
using System.Collections.Generic;

namespace Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee_1 = new Employee(); // created instance of employee class
            Employee employee_2 = new Employee();

            var employee_data = new List<Employee>() {
                new Employee(){ employee_Id = 1, firstname="Bill", lastname="maher"},
                new Employee(){ employee_Id = 2, firstname="Steve", lastname="jobs"},
                new Employee(){ employee_Id = 3, firstname="Ram", lastname="dolph"},
                new Employee(){ employee_Id = 4, firstname="Abdul", lastname="jamar"},
                new Employee(){ employee_Id = 5, firstname="joe", lastname="thomas"},
                new Employee(){ employee_Id = 6, firstname="henry", lastname="jones"},
                new Employee(){ employee_Id = 7, firstname="terrel", lastname="stevens"},
                new Employee(){ employee_Id = 8, firstname="hatna", lastname="rutger"},
                new Employee(){ employee_Id = 9, firstname="don", lastname="martinez"},
                new Employee(){ employee_Id = 10, firstname="joe", lastname="jackson"},
            };
            foreach (Employee employee in employee_data)
            {
                
            }

        }
    }
}

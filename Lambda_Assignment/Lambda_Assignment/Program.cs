using System;
using System.Collections.Generic;

namespace Lambda_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employee_data = new List<Employee>();
            employee_data.Add(new Employee("michael", "desantis", 1));
            employee_data.Add(new Employee("john", "smith", 2));
            employee_data.Add(new Employee("joe", "thomas", 3));
            employee_data.Add(new Employee("kyle", "kyzer", 4));
            employee_data.Add(new Employee("joe", "smith", 5));
            employee_data.Add(new Employee("rob", "desantis", 6));
            employee_data.Add(new Employee("don", "checho", 7));
            employee_data.Add(new Employee("larry", "oConnor", 8));
            employee_data.Add(new Employee("michael", "asumgua", 9));
            employee_data.Add(new Employee("garry", "lazereth", 10));

            List<string> num_of_joes = employee_data.FindAll()
            foreach (var joe in num_of_joes)
            {
                if (employee_data.FindAll("joe"));
            }
        }
    }
}

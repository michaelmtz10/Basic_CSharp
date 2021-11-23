using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee_data = new List<Employee>();
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

            List<Employee> the_joes = new List<Employee>();

            foreach (var joe in employee_data)
            {
                if (employee_data.Equals("joe"))
                {
                    the_joes.Add(joe);
                }
                Console.WriteLine(the_joes);
            }
                
        }
    }
}

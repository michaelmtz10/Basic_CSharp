using System;
using System.Collections.Generic;

namespace Abstract_Class
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

            var list_of_joe = new List<Employee>();
            foreach (var joe in list_of_joe)
            {
                if (employee_data.Equals("joe"))
                {
                    list_of_joe.Add(joe);
                }
            }
            List<Employee> find_joe = employee_data.FindAll(z => z.first_name == "joe"); 
            {
                foreach(var thy_joe in find_joe)
                {
                    Console.WriteLine(thy_joe);
                }
            }
            List<Employee> greater_than_5 = employee_data.FindAll(e => (e.employee_Id >= 5));
            foreach (var g_tham in greater_than_5)
            {
                Console.WriteLine(greater_than_5);
            }
            Console.WriteLine();
        }
    }
}

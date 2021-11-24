using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee_data = new List<Employee>(); // created a list which contains 3 different arguments.
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

            List<Employee> the_joes = new List<Employee>(); // created another list which will contain only the first_name matching with joe.

            foreach (var joe in employee_data) // foreach loop will iterate through list and find the string "joe".
            {
                if (joe.first_name == "joe") // if statement applies condition
                {
                    the_joes.Add(joe); // add the item to a list
                    Console.WriteLine(joe.first_name); // prints list to the console
                }
              
            }
            List<Employee> find_joe = employee_data.FindAll(z => z.first_name == "joe"); // create a lambda expression to find string joe
            {
                foreach (var thy_joe in find_joe) // iterate through list
                {
                    Console.WriteLine(thy_joe.first_name);
                }
            }
            List<Employee> greater_than_5 = employee_data.FindAll(e => (e.employee_Id >= 5)); // created another list to find employee_id's greater than 5
            foreach (var g_tham in greater_than_5) // foreach loop iterates through list
            {
                Console.WriteLine(g_tham.employee_Id);
            }
            Console.WriteLine();

        }
    }
}

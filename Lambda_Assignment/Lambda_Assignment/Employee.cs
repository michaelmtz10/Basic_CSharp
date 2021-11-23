using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Assignment
{
    class Employee
    {
        public string first_name;

        public string last_name;

        public int employee_Id // created a iD property that'll be assigned to every employee
        { get; set; }

        public Employee(string fname, string lname, int id)
        {
            first_name = fname;
            last_name = lname;
            employee_Id = id;
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class Employee : Person
    {
        public override void Sayname()
        {
            Console.WriteLine(firstname + lastname + "is a team member");
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace xamconsole
{
  abstract  class Employee
    {
        public string FirstName;
        public string LastName;


        public string GetFullname()
        {
            return FirstName + " " + LastName;
        }
        public abstract double GetMonthalySalary();
    }
}

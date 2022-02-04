using System;
using System.Collections.Generic;
using System.Text;

namespace xamconsole
{
    class FulltimeEmployee:Employee
    {
        public double AnualSalary { get; set; }
        public override double GetMonthalySalary()
        {
            return this.AnualSalary/12;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionEmployeesAfter
{
    public class Employee
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return "Name: " + this.Name;
        }
    }
}

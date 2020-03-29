using System;
using System.Collections.Generic;
using System.Text;

namespace midterm
{
    class Employee
    {
        public int currentYear { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public string workID { get; set; }
        public int yearStartedWked { get; set; }
        public double initSalary { get; set; }

        public Employee(int currentYear, string fName, string lName, string workID, double initSalary)
        {
            this.currentYear = currentYear;
            this.fName = fName;
            this.lName = lName;
            this.workID = workID;
            this.initSalary = initSalary;
        }
        public override string ToString() => $"{fName} {lName}\n" +
            $"ID {workID} \n Year: {yearStartedWked}";
    }
}
/*
 * Create an Employee class with five fields: 
 * first name, last name, workID, yearStartedWked, and initSalary. 
 * It includes constructor(s) and properties to initialize values for all fields.
 */



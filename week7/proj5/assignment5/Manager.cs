using System;
using System.Collections.Generic;
using System.Text;
// Kyle Flores 03/08/20 CITP4350 c# advanced prog

namespace assignment5
{
    class Manager : Worker
    {
        int yearPromo { get; set; }
        int yearsWorkedWorker { get; set; }
        public Manager(int currentYear, string fName, string lName, string workID, int yearStartedWked, double initSalary, int yearPromo) 
            : base(currentYear, fName, lName, workID, yearStartedWked, initSalary)
        {
            this.yearPromo = yearPromo;
        }

        public new double CalcCurSalary()
        {
            try
            {
                yearsWorkedWorker = yearPromo - yearStartedWked;
                yearPromo = yearPromo - currentYear;

                curSalary = initSalary * Math.Pow((1 + .03), yearsWorkedWorker);
                curSalary += initSalary * Math.Pow((1 + .05), yearPromo)+(curSalary*.10);
                return curSalary;
            }
            catch (Exception e)
            {
                return 1.00;
            }
        }



        public override string ToString() => $"\nName:\t{fName} {lName}\n" +
            $"ID#:\t{workID}\nTenure:\t{nYearWked}\nCurrent Salary:\t{curSalary.ToString("C2")}\n\n";
    

    }
}

/*
 Create a Manager class that is derived from Worker class.
In Manager class, 
it includes one field: 
yearPromo and constructor(s). 

It includes a CalcCurSalary function 
that calculate the current year salary

by overriding the base class function using initial salary 
with 5% yearly increment plus 10% bonus. 

The manager’s salary calculates in two parts. 
It calculates as a worker before the year promoted 
and as a manager after the promotion.

 */

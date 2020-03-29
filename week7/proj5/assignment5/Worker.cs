using System;
using System.Collections.Generic;
using System.Text;
// Kyle Flores 03/08/20 CITP4350 c# advanced prog

namespace assignment5
{
    class Worker : Employee, ISalaryCalculate
    {
        public int nYearWked { get; set; }
        public double curSalary { get; set; }

        public Worker(int currentYear, string fName, string lName, string workID, int nYearWked, double initSalary)
            : base (currentYear, fName, lName, workID, initSalary)
        {
            this.nYearWked = nYearWked ;
            CalcYearWorked(2020);
            CalcCurSalary();
        }

        public double CalcCurSalary()
        {
            try {
                curSalary = initSalary * Math.Pow((1 + .03), nYearWked);
                return curSalary;
            }
            catch(Exception e)
            {
                return 1.00;
            }
        }

         public int CalcYearWorked(int currentyear)
        {
            try
            {
                //DateTime pres_year = new DateTime();
                nYearWked = currentyear - nYearWked;
                return nYearWked;
            }
            catch (Exception e)
            {
                throw new NotImplementedException();
                 
            }
        }
        public override string ToString() => $"\nName:\t{fName} {lName}\n" +
            $"ID#:\t{workID}\nTenure:\t{nYearWked}\nCurrent Salary:\t{curSalary.ToString("C2")}\n\n";
    }
}
/*
 Create a Worker classes that is derived from Employee and SalaryCalculate class.
•	In Worker class, it includes two field, 
nYearWked
curSalary, 
constructor(s). 

It defines the CalcYearWorked() function using 
(current year – yearStartedWked) 
and save it in the nYearWked variable. 

It also defines the CalcCurSalary() function that 
calculates the current year salary by using 
initial salary with 3% yearly increment. 

 */

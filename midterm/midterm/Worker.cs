using System;
using System.Collections.Generic;
using System.Text;

namespace midterm { 
    class Worker : Employee
    {
        public int nYearWked { get; set; }
        public double curSalary { get; set; }

        public Worker(int currentYear, string fName, string lName, string workID, int nYearWked, double initSalary)
            : base(currentYear, fName, lName, workID, initSalary)
        {
            this.nYearWked = nYearWked;
            CalcYearWorked(2020);
            CalcCurSalary();
        }

        public double CalcCurSalary()
        {
            try
            {
                curSalary = initSalary * Math.Pow((1 + .03), nYearWked);
                return curSalary;
            }
            catch (Exception e)
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

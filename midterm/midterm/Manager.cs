using System;
using System.Collections.Generic;
using System.Text;

namespace midterm
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
                    curSalary += initSalary * Math.Pow((1 + .05), yearPromo) + (curSalary * .10);
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

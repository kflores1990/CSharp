using System;
using System.Collections.Generic;
using System.Text;

namespace _4350Review4
{
    class Employee
    {
        private String firstN { get; set; }
        private String lastN { get; set; }

        private int idNum { get; set; }

        private readonly double regHrsAmt = 40;
        private double Wage { get; set; }
        private double WeekHrsWkd { get; set; }
        private double regPay { get; set; }
        private double otPay { get; set; }

        public Employee(string firstN, string lastN, int idNum, double wage, double weekHrsWkd) : this(firstN, lastN)
        {
            this.idNum = idNum;
            Wage = wage;
            WeekHrsWkd = weekHrsWkd;
            this.regPay = regPay;
            this.otPay = otPay;
        }

        public Employee(string firstN, string lastN)
        {
            this.firstN = firstN;
            this.lastN = lastN;

            Console.WriteLine("What is the ID number of the employee: ");
            this.idNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How much is the employee paid: ");
            this.Wage = Convert.ToDouble(Console.ReadLine());                //holds how much the person makes per hour
        }//end second constructor
        
        public  double[]  CalcPay()
        {
            double[] val = new double[2];
            if (WeekHrsWkd <= 40)
            {
                
                regPay = 40 * Wage;
                otPay = 0;
                val[0] = regPay;
                val[1] = otPay;

                return val;
            }
            else
            {
                regPay = 40 * Wage;
                otPay = (((WeekHrsWkd - 40) * Wage) * 1.5);
                val[0] = regPay;
                val[1] = otPay;

                return val;

            }

        }
        public double[] CalcPay(double[] weeks)
        {
            double week1, week2, week3, week4;
            week1 = weeks[0];
            week2 = weeks[1];
            week3 = weeks[2];
            week4 = weeks[3];
            Console.WriteLine(week1);
            double[] val = new double[2];


            regPay += (week1 <= 40) ? week1 * Wage : 40 * Wage;
            regPay += (week2 <= 40) ? week2 * Wage : 40 * Wage;
            regPay += (week3 <= 40) ? week3 * Wage : 40 * Wage;
            regPay += (week3 <= 40) ? week4 * Wage : 40 * Wage;

            otPay += (week1 >= 40) ? (week1 - 40) * Wage * 1.5 : 0;
            otPay += (week2 >= 40) ? (week1 - 40) * Wage * 1.5 : 0;
            otPay += (week3 >= 40) ? (week1 - 40) * Wage * 1.5 : 0;
            otPay += (week3 >= 40) ? (week1 - 40) * Wage * 1.5 : 0;






            val[0] = regPay;
            val[1] = otPay;

            return val;
        }
    }
}
/*
You are to create a class object called “Employee” 
which included
-------------eight private variables:----------------
----firstN 
----lastN 
----idNum
----Wage---- holds how much the person makes per hour 
----WeekHrsWkd---- holds how many total hours the person worked each week. 
----regHrsAmt ----- initialize to a fixed amount of 40 using constructor
----regPay
----otPay
After going over the regular hours, the employee gets 1.5x the wage 
for each additional hour worked.
----------------------Methods-----------------
----constructor
----properties
----CalcPay(): Calculate the regular pay and overtime pay
*/

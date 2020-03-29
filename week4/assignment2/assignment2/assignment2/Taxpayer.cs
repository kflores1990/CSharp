using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    class Taxpayer
    {
        public string SSN;
        public double grossIncome;
        readonly double taxOwed;
        public static double totalTaxAmt = 0;

        public Taxpayer(string SSN = "000000000", double grossIncome = 0)
        {
            this.SSN = SSN;
            this.grossIncome = grossIncome;
            taxOwed = grossIncome < 30000 ? grossIncome * .15 : grossIncome * .28;
        }
        public void printInfo()
        {

            Console.WriteLine("SSN: " + SSN);
            Console.WriteLine("Gross: " + grossIncome);
            Console.WriteLine("TaxOwed: " + taxOwed);


        }


    }
}


/*
 * 
 *  Data fields for Taxpayer class include the Social Security number 
 * (use a string for the type, but do not use dashes within the number),
 * the yearly gross income,
 * the tax owed, 
 * and totalTaxAmt (static variable). 
•   The class includes the properties with get and set for the first two data fields,
but make the tax owed a read-only property. 
The tax should be calculated whenever the income is set.
Assume the tax is 15% of income 
for incomes under $30,000 
and 28% for incomes that are $30,000 or higher. 

    After the tax owed is calculated, 
the tax owed is added into totalTaxAmt.
*/
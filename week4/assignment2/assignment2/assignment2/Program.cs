/*
 * Kyle Flores 
   CITP 4350
   2/16/20
*/


using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrSize = 0;
            String tempSSN = " ";
            Double tempGross = 0;
            Console.Write("How many entries: ");
            arrSize = Convert.ToInt32(Console.ReadLine());

            Taxpayer[] arr = new Taxpayer[arrSize];

            for (int i=0; i < arr.Length; i++)
            {
                Console.WriteLine("Input SSN: ");
                tempSSN = Console.ReadLine();

                Console.WriteLine("Input GrossIncome: ");
                tempGross = Convert.ToDouble(Console.ReadLine());


                Taxpayer.totalTaxAmt += 
                    tempGross < 30000 ? tempGross * .15 : tempGross * .28;
                arr[i] = new Taxpayer(tempSSN, tempGross);

            }
            Array.Sort(arr, delegate (Taxpayer user1, Taxpayer user2) {
                return user1.grossIncome.CompareTo(user2.grossIncome); 
            });

            for (int i=0; i< arr.Length; i++)
            {
                arr[i].printInfo();

            }
            Console.WriteLine("\n\nThe total tax amount is: " +Taxpayer.totalTaxAmt);




            Console.ReadLine();
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
 * 
 * 
•   The class includes the properties with get and set for the first two data fields,
but make the tax owed a read-only property. 


The tax should be calculated whenever the income is set.


Assume the tax is 15% of income 
for incomes under $30,000 
and 28% for incomes that are $30,000 or higher. 

    After the tax owed is calculated, 
the tax owed is added into totalTaxAmt.
*/

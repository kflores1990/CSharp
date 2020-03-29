using System;
using System.Collections.Generic;
using System.Text;

namespace _4350Review4
{
    class EmployeeDemo
    {
        int numberEmployees;
        readonly int weeks = 5;
        

        public EmployeeDemo()
        {
            Console.WriteLine("Enter number of Employees: ");
            this.numberEmployees = Convert.ToInt32(Console.ReadLine());
             string[,] arr = new String[numberEmployees, weeks];
            
            for (int i=0; i < numberEmployees; i++)
            {
                Console.WriteLine("Enter name " + (i+1) + " out of " + numberEmployees + " name: ");
                string s1 = Console.ReadLine();
                arr[i, 0] = s1;
                for (int j=0; j<(weeks-1); j++)
                {
                    Console.WriteLine("Enter week " + (j+1) + " out of 4:");
                    string s2 = Console.ReadLine();
                    arr[i, (j+1)] = s2;

                }
            }

            char cont = 'y';
            while (cont == 'y')
            {
                Console.WriteLine("Which employee would you like to display" + " ");
                for (int k = 0; k < numberEmployees; k++)
                {
                    Console.WriteLine("\nEmployee:\n " + (k + 1)+" " + arr[k, 0]);
                }

                int userToDisplay = (Convert.ToInt32(Console.ReadLine()) - 1);
                Console.WriteLine("Displaying employee: " + arr[userToDisplay, 0]);
                
                String fName = " "; String lName = " ";
                fName = arr[userToDisplay, 0].Substring(0, arr[userToDisplay, 0].IndexOf(" "));
                lName = arr[userToDisplay, 0].Substring(0, arr[userToDisplay, 0].IndexOf(" "));
                Employee test = new Employee(fName, lName);

                Console.WriteLine("Choose a numerical option from the menu: ");

                Console.WriteLine("1. How much " + lName + " totally made");
                Console.WriteLine("2. How much regular pay for " + lName+ " is");
                Console.WriteLine("3. How much " + lName + " made");
                
                double[] hrsworked = new double[4];
                for (int i =0; i < 4; i++)
                {
                    hrsworked[i] = Convert.ToDouble(arr[userToDisplay, i + 1]);
                }


                double[] val = new double[2];
                val = test.CalcPay(hrsworked);                
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("\nTotal amount: " + (val[0]+val[1]));
                        break;
                    case 2:
                        Console.WriteLine("\n regular pay amount: " + val[0]);

                        break;
                    case 3:
                        Console.WriteLine("\n overtime pay amount: " + val[1]);

                        break;
                    default:
                        Console.WriteLine("Input option invalid please select numerical value");
                        break;
                }
                

                Console.WriteLine("Display another employee(y/n)?");
                cont = Convert.ToChar(Console.ReadLine());//end



            }

        }
    }
}
/*
------------Create an “EmployeeDemo” class. In the main function,------

the program should ask the user the number of employee 
in the company and create a 2-dimensional dynamic array 
(number of employee by 4 weeks). 
Then, the program should ask user to enter each employee’s 
information and the amount of hours they worked weekly
*/

/*
The program shows a menu with employee name for user to choose which 
employee to 
---------display the following information:-----
How much the person totally made
How much of paycheck is regular pay 
How much of paycheck is overtime pay


                Console.WriteLine("\n\nDisplay total pay of" + " ");
                Console.WriteLine("Display regular pay" + " ");
                Console.WriteLine("Display overtime pay" + " ");
                Console.WriteLine("Display another (y/n)?");







    for (int k = 0; k <numberEmployees; k++)
            {
                Console.WriteLine("\nEmployee: "+ arr[k, 0]);

                for (int m = 1; m < weeks; m++)
                {
                    Console.WriteLine("Week: "+m+ " " + arr[k, m]);
                }
            }




*/

using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeExceptionDemo2
{
    class Employee
    {
        protected int idNum { get; set; }
        protected double hourlyWage { get; set; }

        public Employee(int idNum , double hourlyWage)
        {
            try
            {
                if (hourlyWage < 50.00 && hourlyWage >= 7.50)
                {
                    this.idNum = idNum;
                    this.hourlyWage = hourlyWage;
                    Console.WriteLine("employee: " + idNum + " \n Wage is: " + hourlyWage);
                }
                else
                {
                    
                    throw new Exception();
                }
            }

            catch (Exception e)
            {
                hourlyWage = 7.50;
                idNum = 999;
                Console.WriteLine("employee: " + idNum + " \n Wage is: " + hourlyWage);


            }
        }
    }
}

/*
 2. Write an application that creates an array of five Employees.
 Prompt the user for values for each field for each Employee. 
 If the user enters improper or invalid data, 
 handle any exceptions that are thrown by setting the 
 Employee’s ID number to 999 
 and the Employee’s pay rate to the $7.50. 
 
    At the end of the program, display all the entered, 
    and possible corrected, records. 
    
    Save the file as EmployeeExceptionDemo2.cs.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeExceptionDemo
{
    class Employee
    {
        protected int idNum { get; set; }
        protected double hourlyWage { get; set; }

        public Employee(int idNum, double hourlyWage)
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
            
            catch(Exception e)
            {
                Console.WriteLine("Incorrect value entered. " +
                    "Wage needs to be between $7.50 and $50.00\n value entered was: " + hourlyWage);

                
            }
        }
    }
}
/*

1. Create an Employee class with two fields: 
idNum
hourlyWage.

The Employee constructor requires values for both fields.
Upon construction, 
thrown an ArgumentException if the 
hourlyWage is less than 7.50 
more than 50.00.

Write a program that establishes, 
one at a time, 
at least three Employees with hourlyWages that are 
above, 
below, 
and within the allowed range.

Immediately after each instantiation attempt, 
handle any thrown Exceptions by displaying an error message.
Save the file as EmployeeExceptionDemo.cs.
*/

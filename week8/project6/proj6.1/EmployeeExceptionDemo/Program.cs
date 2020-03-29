using System;
// Kyle Flores 03/15/20 CITP 4350 Assignment 6
namespace EmployeeExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {





            Employee e1 = new Employee(123, 55.00);
            Employee e2 = new Employee(456, 01.00);
            Employee e3 = new Employee(789, 25.00);



            Console.ReadLine();
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
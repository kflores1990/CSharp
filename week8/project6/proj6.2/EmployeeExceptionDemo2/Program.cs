using System;

namespace EmployeeExceptionDemo2
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee[] eArr = new Employee[5];

            for (int x = 0; x < 5; x++)
            {
                eArr[x] = new Employee((x+100+1), (x*15));
            }



            Console.Read();
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

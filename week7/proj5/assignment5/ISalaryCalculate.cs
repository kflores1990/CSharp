using System;
using System.Collections.Generic;
using System.Text;
// Kyle Flores 03/08/20 CITP4350 c# advanced prog

namespace assignment5
{
    interface ISalaryCalculate
    {
        abstract int CalcYearWorked(int currentyear);
        public abstract double CalcCurSalary();

    }
}


/*
 Create an interface, SalaryCalculate, class that includes two functions: 
 first
 CalcYearWorked() function, 
 it takes one parameter (currentyear)  
 calculates the number of year the worker has been working. 
 
 The second function, 
 CalcCurSalary() function 
 calculates the current year salary. 
 */

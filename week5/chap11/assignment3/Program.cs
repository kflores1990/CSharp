using System;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {

            Loan aLoan = new Loan();
            aLoan.LoanNumber = 2239;
            aLoan.LastName = "Mitchel";
            aLoan.LoanAmount = 1000.00;
            Console.WriteLine($"Loan #{aLoan.LoanNumber} for {aLoan.LastName} is for {aLoan.LoanAmount.ToString("C2")}");


            Console.ReadLine();
        }
    }
}
/*
 * 
 * Create  general loan class that holds data pertaining to a bank loan
 * ---loan number
 * ---customer name (Last seperated)
 * ---amount borrowed
 * 
 * write a program to instantiate and use a loan object
 * 
 * Create a CarLoan derived calss that adds
 * ---info about the automobile that serves as collateral for the loan
 * 
 * demo the CarLoan
 * 
 * 
 * 
 * 
 * 
 */
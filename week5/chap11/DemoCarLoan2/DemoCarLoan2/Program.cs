using System;

namespace DemoCarLoan2
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

            CarLoan aCarLoan = new CarLoan();

            aCarLoan.LoanNumber = 3358;
            aCarLoan.LastName = "Jansen";
            aCarLoan.LoanAmount = 20000.00;
            aCarLoan.Make = "Ford";
            aCarLoan.Year = 2005;
            Console.WriteLine($"Loan #{aCarLoan.LoanNumber} for " +
                $"{aCarLoan.LastName} is for " +
                $"{aCarLoan.LoanAmount.ToString("C2")}");
            Console.WriteLine($"Loan #{aCarLoan.LoanNumber} for " +
                $"{aCarLoan.LastName} is for a " +
                $"{aCarLoan.Year} {aCarLoan.Make}");

            Console.ReadLine();
        }
    }
}

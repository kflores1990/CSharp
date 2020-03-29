using System;

namespace DemoCarLoan3
{
    class Program
    {
        static void Main(string[] args)
        {

            Loan aLoan = new Loan(111, "sim", 7000.00);
            aLoan.LoanNumber = 2239;
            aLoan.LastName = "Mitchel";
            aLoan.LoanAmount = 1000.00;
            Console.WriteLine($"Loan #{aLoan.LoanNumber} for {aLoan.LastName} is for {aLoan.LoanAmount.ToString("C2")}");

            CarLoan aCarLoan = new CarLoan(222, "smith", 30000.00, 2011, "BMW");

            aCarLoan.LoanNumber = 3358;
            aCarLoan.LastName = "Jansen";
            aCarLoan.LoanAmount = 20000.00;
            aCarLoan.Make = "Ford";
            aCarLoan.Year = 2005;
            Console.WriteLine($"Loan #{aCarLoan.LoanNumber} for " +
                $"{aCarLoan.LastName} is for " +
                $"{aCarLoan.LoanAmount.ToString("C2")}");
            Console.WriteLine($"Loan #{aCarLoan.LoanNumberds} for " +
                $"{aCarLoan.LastName} is for a " +
                $"{aCarLoan.Year} {aCarLoan.Make}");


            Loan aloan = new Loan(333, "Hanson", 7000.00);
            CarLoan aCarloan = new CarLoan(444, "Carlisle", 30000.00, 2011, "BMW");






            Console.ReadLine();
        }
    }
}

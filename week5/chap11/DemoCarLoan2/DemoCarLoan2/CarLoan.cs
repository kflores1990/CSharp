using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCarLoan2
{
    class CarLoan : Loan
    {
        private int year;
        public string Make { get; set; }
        public new int LoanNumber
        {
            get
            {
                return base.LoanNumber;
            }
            set
            {
                if (value < LOWEST_INVALID_NUM)
                    base.LoanNumber = value;
                else
                    base.LoanNumber = value % LOWEST_INVALID_NUM;
            }
        }

        private const int EARLIEST_YEAR = 2006;
        private const int LOWEST_INVALID_NUM = 1000;

        public int Year
        {
            set
            {
                if (value < EARLIEST_YEAR)
                {
                    year = value;
                    loanAmount = 0;

                }
                else
                    year = value;
            }
            get
            {
                return year;
            }
        }
    }
}

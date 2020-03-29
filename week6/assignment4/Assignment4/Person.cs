using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment4
{
    public abstract class Person
    {
        public String fName { get; }
        public String lName { get; }
        public String address { get; }
        public String pNumber { get; }

        public Person(string fName, string lName, string address, string pNumber)
        {
            this.fName = fName;
            this.lName = lName;
            this.address = address;
            this.pNumber = pNumber;
        }
    }
}




/*
 *Design a class named Person with properties for holding
 * person’s name, 
 * address, 
 * and telephone number.
 * 
 * 
 * 
 * 
 * 
 * /*
 * Design a class named Customer, which is derived from the Person class. 
 * 
 * The Customer class should have the variables and properties for the 
 * customer number, 
 * customer email, 
 * a spentAmount of the customer’s purchases, 
 * and a Boolean variable indicating whether the customer wishes to be on a mailing list.
 * 
 * It also includes 
 * function calcAmount that calculates 
 * spentAmount.
 * 
 * 
 * 
 * 
        private int customerNumber;
        private String custEmail;
        private double spentAmount;
        private Boolean mailList;

 */


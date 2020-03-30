using System;
using System.Collections.Generic;
using System.Text;

namespace assignment9
{
    class Manager : authentication
    {
        private string password = "admin";
        bool mngrAuthenticated ;
        char cont = 'y';
        public Manager(): base ()
        {
            mngrAuthenticated = authenticateUser(password);
            
            while (mngrAuthenticated != true)
            {
                Console.WriteLine("Try again? (y/n)");
                cont = Convert.ToChar(Console.ReadLine());
                if (cont == 'n') { break; }
                else{mngrAuthenticated = authenticateUser(password);}
            }
            menu(mngrAuthenticated);

        }
        private void menu(bool mngrAuthenticated)
        {
            if (mngrAuthenticated != true) { Console.WriteLine("Sorry authentication has failed.\nManager options unavailable"); }
            while (mngrAuthenticated == true && cont == 'y')
            {
                Console.WriteLine("Please choose an option: "
                    + "\n(1). Add to inventory"
                    + "\n(2). Display Inventory");

                int val = Convert.ToInt32(Console.ReadLine());

                if (val == 1) { addStock(); }
                else if (val == 2) { displayInventory(); }
                else { Console.WriteLine("invalid option"); }

                Console.WriteLine("Choose another option?(y/n)");
                cont = Convert.ToChar(Console.ReadLine());
            }
        }
        
        protected void addStock()
        {
            Console.WriteLine("add stock called");

        }
        protected void displayInventory()
        {
            Console.WriteLine("displayInventory called");

        }

    }
}
/*
 * Manager:
	The manager option has to be password protected. The program will give the manager two option:
1.	Display the inventory: display all the products stock information
2.	Restock the products: add more stock for each product


 */

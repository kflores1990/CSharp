using System;
using System.Collections.Generic;
using System.Text;

namespace assignment9
{
    class authentication
    {
        private Boolean authenticated;

        public authentication()
        {
        }

        protected  Boolean authenticateUser(string a)
        {
            Console.WriteLine("Please Enter Manager Password:");
            return authenticated = string.Equals(Console.ReadLine(), a);
            

        }
    }
}

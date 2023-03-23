using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept.Encapsuation
{
    internal class Account
    {
        private int accountsBalance = 1000;
        public void SetBalance(int balance)
        {
            this.accountsBalance = balance;
        }
        public void GetBalance()
        {
            Console.WriteLine("Your Balance is " + accountsBalance);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.models
{
    internal class BankAccount
    {
        private decimal _balance;

        public string Owner;
        public decimal Balance
        {
            get { return _balance; }
        }
        public BankAccount(string owner, decimal balance)
        {
            Owner = owner;

        }
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Denied");
            }
            else
            {
                _balance += amount;

                Console.WriteLine("Accepted");
            }
      
        }
        public void Withdraw(decimal amount)
        {
            if (_balance < amount && amount <= 0)
            {
                Console.WriteLine("Denied");
            }
            else
            {
                _balance -= amount;

                Console.WriteLine("Accepted");
            }

        }

        public virtual string GetAccountType()
        {
            return "Standard";
        }

    }
}

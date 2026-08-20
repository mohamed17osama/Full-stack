using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.models
{
    internal class SavingsAccount : BankAccount
    {
        public decimal InterestRate;

        public SavingsAccount(string owner, decimal balance):base(owner, balance) 
        { 
            
        }

        public virtual void ApplyInterest(decimal interestRate)
        {
            InterestRate = interestRate;
        }

        public override string GetAccountType()
        {
            return "Savings";
        }
    }
}

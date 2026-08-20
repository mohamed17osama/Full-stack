using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_system.models
{
    internal class PremiumSavingsAccount : SavingsAccount
    {
        public PremiumSavingsAccount(string owner, decimal balance) : base(owner, balance) 
        {

        }
        public override void ApplyInterest(decimal interestRate)
        {
            base.ApplyInterest(interestRate * 2);
        }
        public override string GetAccountType()
        {
            return "Premium Savings";
        }
    }   
}

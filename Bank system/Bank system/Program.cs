using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_system.models;

namespace Bank_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount[] bankAccounts =
            {
                new BankAccount("Mohamed", 6000),

                new SavingsAccount("Osama", 5000),

                new PremiumSavingsAccount("Ahmed", 10000)

            };
            foreach (BankAccount bankAccount in bankAccounts)
            {
                Console.WriteLine(bankAccount.GetAccountType());
            }
            //Can not set Balance directly from outside the class
        }
    }
}

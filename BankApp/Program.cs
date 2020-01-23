using System;

namespace Bankapp
{
    class Program
    {
        static void Main(string[] args)
        {   
            var myAccount = BankApp.Bank.CreateAccount("My Checking","test@test.com",TypeOfAccounts.Savings,100);
            //myAccount.AccountNumber = 123456;
            //myAccount.AccountName = "My Checking";
            //myAccount.Deposit(1001);
            Console.WriteLine($"AN:{myAccount.AccountNumber} ,AN:{myAccount.AccountName} ,AB:{myAccount.Balance}");
            
            /*var myAccount2 = new Account();
            //myAccount2.AccountNumber = 34567;
            myAccount2.AccountName = "My Checking2";
            Console.WriteLine($"AN:{myAccount2.AccountNumber} ,AN:{myAccount2.AccountName} ,AB:{myAccount2.Balance}");*/
        }
    }
}

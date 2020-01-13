using System;

namespace Bankapp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new Account();
            myAccount.AccountNumber = 123456;
            myAccount.AccountName = "My Checking";

            var myAccount2 = new Account();
            myAccount2.AccountNumber = 34567;
            myAccount2.AccountName = "My Checking";
        }
    }
}

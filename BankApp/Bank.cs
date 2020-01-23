using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    static class Bank
    {/// <summary>
    /// Creates an account in the bank
    /// </summary>
    /// <param name="accountName"></param>
    /// <param name="emailAddress"></param>
    /// <param name="AccountType"></param>
    /// <param name="initialDeposit"></param>
    /// <returns></returns>
        public static Bankapp.Account CreateAccount(string accountName,
                                                    string emailAddress,
                                                    Bankapp.TypeOfAccounts AccountType = Bankapp.TypeOfAccounts.Checking,
                                                    decimal initialDeposit=0)
        {
            //Object initialization
            var account = new Bankapp.Account
            {
                AccountName = accountName,
                EmailAddress = emailAddress,
                AccountType = AccountType
            };
            if(initialDeposit>0)
            {
                account.Deposit(initialDeposit);
            }
            return account;

        }

    }
}

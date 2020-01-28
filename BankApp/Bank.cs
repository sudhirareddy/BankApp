using Bankapp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BankApp
{
    static class Bank
    {
        private static readonly IEnumerable<object> account;
        private static List<Account> accounts = new List<Account>();/*Reference type create in memory*/
        /// <summary>
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
            accounts.Add(account);
            return account;

        }
        public static void Deposit(int accountNumber,decimal amount)
        {
            var account= accounts.Where(a => a.AccountNumber ==accountNumber);
        }

    }
}

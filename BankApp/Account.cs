﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Bankapp
{
    enum TypeOfAccounts
    {
        Checking,
        Savings,
        CD,
        Loan
    }/// <summary>
    /// This represents a bank account where you can withdraw or deposit money into an account
    /// </summary>
    class Account
    {
        private static int lastAccountNumber = 0;
        #region Properties
        /// <summary>
        /// Unique Account number
        /// </summary>
        public int AccountNumber { get; private set; }
        public string AccountName { get; set; }
        public TypeOfAccounts AccountType { get; set; }
        public decimal Balance { get; private set; }
        public string EmailAddress { get; set; }
        public DateTime CreatedDate { get; set; }
        #endregion

        #region Constructor
        public Account()
        {
            AccountNumber = ++lastAccountNumber;
            CreatedDate = DateTime.UtcNow;
    }
        #endregion

        #region Methods
        /// <summary>
        /// Deposit money into account
        /// </summary>
        /// <param name="amount"></param>
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public decimal Withdraw(decimal amount)
        {
            Balance-= amount;
            return Balance;
        }
        #endregion
    }
}

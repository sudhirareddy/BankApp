using System;
using System.Collections.Generic;
using System.Text;

namespace Bankapp
{
    class Account
    {
        #region Properties
        /// <summary>
        /// Unique Account number
        /// </summary>
        public int AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string AccountType { get; set; }
        public decimal Balance { get; set; }
        public string EmailAddress { get; set; }
        public DateTime CreatedDate { get; set; }
        #endregion
    }
}

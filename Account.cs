using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day8
{
    internal struct Account
    {
        #region Atrributes
        private int accountId;
        private string accountHolder;
        private double balance;
        #endregion

        #region properties
        public int AccountId
        {
            get { return accountId; }
            set { accountId = value; }
        }
        public string AccountHolder
        {
            get { return accountHolder; }
            set { accountHolder = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        #endregion

        public override string ToString()
        {
            return $"ID = {AccountId} , Name = {AccountHolder} , Balance = {Balance}";
        }
    }
}

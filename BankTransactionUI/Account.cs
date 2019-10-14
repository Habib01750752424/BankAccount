using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTransactionUI
{
    public class Account
    {
        public string accountNumber;
        public string customerName;
        public double balance;

        public void CreateAccount(string aNo,string cName)
        {
            accountNumber = aNo;
            customerName = cName;
        }

        public double Deposit(double balnce)
        {
            balance = balance + balnce;
            return balance;
        }

        public double Widthdraw(double balnce)
        {
            balance = balance - balnce;
            return balance;
        }
    }
}

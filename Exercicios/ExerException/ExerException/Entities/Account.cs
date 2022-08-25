using System;
using System.Globalization;
using ExerException.Entities.Exceptions;

namespace ExerException.Entities
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }

            if (Balance < WithdrawLimit)
            {
                throw new DomainException("Not enough balance");
            }
            Balance -= amount;
        }
        public override string ToString()
        {
            return "New Balance: " + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

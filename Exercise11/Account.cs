using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise11
{
    abstract class Account
    {
        private double balance;

        public Account()
        {
                this.balance = 0.00;
        }

        public virtual void deposit(double money) 
        {
            balance += money;

            Console.WriteLine($"A total of ${money.ToString("F")} has been deposited to your account.");

            getBalance();
        }

        public void withdraw(double money)
        {
            if (balance >= money)
            {
                balance -= money;
                Console.WriteLine($"A total of ${money.ToString("F")} has been withdrawm from your account.");
            }
            else
            {
                Console.WriteLine("You don't have enough funds to withdraw that account");
            }

            getBalance();
        }
        public void getBalance()
        {
            Console.WriteLine($"Your current balance is ${balance.ToString("F")}");
        }

    }
}

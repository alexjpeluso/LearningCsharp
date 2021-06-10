using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise11
{
    class SavingsAccount : Account
    {
        public override void deposit(double money)
        {
            double bonus = Math.Floor(money / 100);

            if (bonus > 0)
            {
                Console.WriteLine($"You have earned ${bonus} of bonus bucks!");
            }

            base.deposit(money + bonus);
        }
    }
}

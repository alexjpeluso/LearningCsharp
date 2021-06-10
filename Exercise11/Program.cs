using System;

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {

            CheckingAccount myChecking = new CheckingAccount();
            SavingsAccount mySavings = new SavingsAccount();

            int selectedAccount = 0;

            do
            {
                Console.WriteLine("Welcome! Please make a selection");
                Console.WriteLine("1 - Checking Account");
                Console.WriteLine("2 - Savings Account");
                Console.WriteLine("3 - Exit");

                selectedAccount = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                if (selectedAccount != 3)
                {
                    int accountAction;

                    do
                    {
                        Console.WriteLine("1 - Deposit");
                        Console.WriteLine("2 - Withdraw");
                        Console.WriteLine("3 - Check Balance");
                        Console.WriteLine("4 - Exit");

                        accountAction = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();

                        switch (accountAction)
                        {
                            case 1:
                                Console.Write("Enter the amount to deposit: ");

                                if (selectedAccount == 1)
                                {
                                    myChecking.deposit(Convert.ToDouble(Console.ReadLine()));
                                }
                                else if (selectedAccount == 2)
                                {
                                    mySavings.deposit(Convert.ToDouble(Console.ReadLine()));
                                }

                                Console.WriteLine();

                                break;

                            case 2:

                                Console.Write("Enter the amount to withdraw: ");

                                if (selectedAccount == 1)
                                {
                                    myChecking.withdraw(Convert.ToDouble(Console.ReadLine()));
                                }
                                else if (selectedAccount == 2)
                                {
                                    mySavings.withdraw(Convert.ToDouble(Console.ReadLine()));
                                }

                                Console.WriteLine();

                                break;

                            case 3:

                                if (selectedAccount == 1)
                                {
                                    myChecking.getBalance();
                                }
                                else if (selectedAccount == 2)
                                {
                                    mySavings.getBalance();
                                }

                                Console.WriteLine();

                                break;

                            case 4:
                                break;

                        } 
                    } while (accountAction != 4);
                }


            } while (selectedAccount != 3);
            
        }
    }
}

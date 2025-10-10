using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Account
    {
        public int balance = 0;
        public void Deposit(int amount)
        {
            balance += amount;
            Console.WriteLine("Deposited:" + amount);
        }
        public void withdraw(int amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("withdraw amount:" + amount);
            }
            else
            {
                Console.WriteLine("not enough balance!");
            }
        }
        public void ShowBalance()
        {
            Console.WriteLine("current balance:" + balance);

        }
    }
}

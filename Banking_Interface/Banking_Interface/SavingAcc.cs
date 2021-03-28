using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Interface
{
    class SavingAcc:IBasicBanking
    {
        public int balance { get; set; }

        public bool Deposite(int amount)
        {
            balance += amount;
            Console.WriteLine("New balance after deposite is:" + balance);
            return true;
        }

        public bool Withdraw(int amount)
        {
            if (amount <= 80* balance/100)
            {
                balance -=amount;
                Console.WriteLine("New balance after withdraw is:" + balance);
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
            return true;
        }
    }
}

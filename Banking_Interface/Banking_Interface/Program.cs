using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Current Account");
            CurrentAcc C = new CurrentAcc();
            C.balance = 1000;
            C.Deposite(500);
            C.Withdraw(1500);

            Console.WriteLine("Saving Account");
            SavingAcc S = new SavingAcc();
            S.balance = 2000;
            S.Deposite(2000);
            S.Withdraw(3201);


            Console.WriteLine("Over Draft Account");
            OverdraftAcc O = new OverdraftAcc();
            O.balance = 500;
            O.Deposite(500);
            O.Withdraw(1200);
        }
    }
}

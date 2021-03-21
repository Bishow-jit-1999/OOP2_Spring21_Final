using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Account A = new SpecialSaving("Bishowjit", "000111222", 20, 10);
            Account B = new SpecialSaving("Rahim", "000111223", 300.50, 200.50);

            Account C = new OverDraft("Karim", "1122334", 20, 5);
            Account D = new OverDraft("Jon", "22233344", 8000.75, 5000);

            A.ShowInfo();
            A.Deposit(5);
            A.Withdraw(20);
            A.Transfer(B, 2);

            Console.WriteLine("*************************************");

            C.ShowInfo();
            C.Deposit(15);
            C.Withdraw(15);
            C.Transfer(D, 10);
            




        }
    }
}

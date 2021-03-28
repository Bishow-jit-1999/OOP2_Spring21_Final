using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Interface
{
    interface IBasicBanking
    {
        bool Deposite(int amount);
        bool Withdraw(int amount);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Up_gradation_of_Account_class
{
    class Account
    {
        public string AccName { get; set; }
        public string AccNo { get; }
        public double Balance { get; set; }
        Transaction[] transactions;
        public int totalNumberOfTransaction { get; set; }

        public Account() { }
        public Account(string accName, string accNo, double balance)
        {   
            AccName = accName;
            AccNo = accNo;
            Balance = balance;
            transactions = new Transaction[10];
        }
        public void AddTransaction(params Transaction[] transactions)
        {
          foreach(var a in transactions)
            {
                this.transactions[totalNumberOfTransaction++] = a;
            }
        }

        public void showAllTranscation()
        {
            for(int i=0;i< totalNumberOfTransaction;i++)
            {
                transactions[i].ShowInfo();
            }
        }


        public void Deposit(double amount)
        {
            Balance += amount;
            transactions[totalNumberOfTransaction++] = new Transaction(this, this, amount , "Self deposit");
            Console.WriteLine("Current Balance after Deposit is {0}", Balance);
        }
        public void ShowInfo()
        {
            Console.WriteLine("Acc Name: " + AccName);
            Console.WriteLine("Acc No: " + AccNo);
            Console.WriteLine("Balance: " + Balance);

        }
        virtual public void Withdraw(double amount)
        {
            if (amount < Balance)
            {
                Balance -= amount;
                transactions[totalNumberOfTransaction++] = new Transaction(this, this, amount, "Self withdraw");

                Console.WriteLine(transactions[i].ShowInfo());
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }
        virtual public void Transfer(Account acc, double amount)
        {
           if (amount < Balance)
            {
                Balance -= amount;
                transactions[totalNumberOfTransaction++] = new Transaction(this, acc, amount, "Transfer to another account");
                Console.WriteLine("Current Balance after transfer is {0}", Balance);
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }
        }

    }
}


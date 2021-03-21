using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Up_gradation_of_Account_class
{
    class Transaction
    {
        public Account Sender { get; set; }
        public Account Receiver { get; set; }
        public double amount { get; set; }
        public string  additional_info { get; set; }
      

        public Transaction()
        {

        }

        public Transaction(Account Sender,Account Receiver,double amount,string additional_info)
        {
            this.Sender = Sender;
            this.Receiver = Receiver;
            this.amount = amount;
            this.additional_info = additional_info;
        }

         public void ShowInfo()
        {
            Console.WriteLine("Sender Id {0}",Sender.AccNo);
            Console.WriteLine("Sender ACC Name {0}", Sender.AccName);
            Console.WriteLine("Receiver Id {0}",Receiver.AccNo);
            Console.WriteLine("Receiver ACC Name {0}", Receiver.AccName);
            Console.WriteLine("Transaction amount is {0}", amount);
            Console.WriteLine("Type of Transaction {0}", additional_info);


        }


    }
}

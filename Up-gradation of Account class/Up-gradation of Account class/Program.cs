using System;

namespace Up_gradation_of_Account_class
{
    class Program
    {
        static void Main(string[] args)
        {

            Account Sender1 = new Account("Bishowjit Saha", "0111222333", 5000.75f);
            Account Receiver1 = new Account("Zannat", "0000111222", 6000.75f);
            Account Receiver2 = new Account("Rahim", "00055556666", 1500.25f);
            Account Sender2 = new Account("Karim", "88889999", 3000.50f);

            Transaction T1 = new Transaction(Sender1, Receiver1, 500, "Send Money");
            Transaction T2 = new Transaction(Sender1, Receiver2, 100, "Recharge");
            Transaction T3 = new Transaction(Sender1, Receiver1, 1000, "Payment");
            Transaction T4 = new Transaction(Sender2, Receiver2, 999f, "Bill Pay");

            Sender1.Deposit(150.55f);
            Console.WriteLine("****************************");
            Sender1.Withdraw(200);
            Console.WriteLine("****************************");
            Sender1.Transfer(Receiver2, 600);
            Console.WriteLine("****************************");

            Sender1.AddTransaction(T1, T2, T3, T4);
            Sender1.ShowAllTranscation();



        }
    }
}

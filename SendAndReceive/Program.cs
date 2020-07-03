using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendAndReceive
{
    public class Send
    {
        public int Amount { get; set; }

        public string Name {get;set;}

        public string Account { get; set; }

        public Send()
        {
            Amount = 1000;
        }

      public int sendmMoney(string account,string name,int sendAmount)
        {
          //  int result;
            this.Account = account;
            this.Name = name;

            if(Account=="123" && Name == "Pratik")
            {
               Amount =Amount - sendAmount;
            }
            return Amount;
        }

    }

    public class Receive
    {
        public int Amount { get; set; }

        public string Name { get; set; }

        public string Account { get; set; }

        public Receive()
        {
            Amount = 0;
        }

        public int ReceiveMoney(string account, string name, int ReceiveAmount)
        {
            this.Account = account;
            this.Name = name;

            if (Account == "345" && Name == "Prabodh")
            {
                Amount = Amount + ReceiveAmount;
            }
            return Amount;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Send send = new Send();
            Console.WriteLine("Enter Name");
            send.Name = Console.ReadLine();
            Console.WriteLine("Enter Account");
            send.Account = Console.ReadLine();
            Console.WriteLine("Enter Amount");
            int SendAmount = Convert.ToInt16(Console.ReadLine());

            Receive receive = new Receive();
            Console.WriteLine("Enter Name");
            receive.Name = Console.ReadLine();
            Console.WriteLine("Enter Account");
            receive.Account = Console.ReadLine();


            int sendValue = send.sendmMoney(send.Account, send.Name, SendAmount);

            int receiveValue= receive.ReceiveMoney(receive.Account, receive.Name, SendAmount);

            Console.WriteLine("==================================================");

            Console.WriteLine("Receipt");

            Console.WriteLine("Amount transfer to Person :{0} From Person: {1}",receive.Name,send.Name);

            Console.WriteLine("Amount transfer to  Account:{0} From Account:{1}", receive.Account, send.Account);

            Console.WriteLine("Sender Balance: {0}", sendValue);

            Console.WriteLine("Receiver Balance: {0}",receiveValue);

            Console.WriteLine("==================================================");


            Console.ReadKey();
        }
    }
}

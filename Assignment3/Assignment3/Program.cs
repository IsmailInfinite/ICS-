using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bank
{
    class miabank
    {
        private double balance = 1;


        public double bal
        {
            get { return balance; }
            set { balance = value; }
        }
    }
    class functions
    {
        miabank i = new miabank();
        string name;
        int account;
        double withdraw, deposit, total;

        public void dep1()
        {
            Console.WriteLine("Enter Name of the depositor :");
            name = Console.ReadLine();
            Console.WriteLine("Enter Account Number  :");
            account = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Deposit Amount :");
            deposit = Convert.ToDouble(Console.ReadLine());
            total = i.bal + deposit;
            Console.WriteLine("Name of the depositor : " + name);
            Console.WriteLine("Account Number: " + account);
            Console.WriteLine("Total Balance amount in the account  : " + total);
        }
        public void dep2()
        {
            Console.WriteLine("Enter Account Name :");
            name = Console.ReadLine();
            Console.WriteLine("Enter Account Number  :");
            account = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Withdraw Amount :");
            withdraw = Convert.ToDouble(Console.ReadLine());
            if (withdraw <= i.bal)
            {
                total = i.bal - withdraw;
                Console.WriteLine("Account Name : " + name);
                Console.WriteLine("Account Number: " + account);
                Console.WriteLine("After Withdraw Amount balnace is : " + total);
            }
            else
                Console.WriteLine("\nWithdraw Ammount does not Exist your Account.");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            char again;
            do
            {
                functions k = new functions();
                int num;
                Console.WriteLine("Select option below.");
                Console.WriteLine("1.Deposit. \n2.Withdraw.");
                num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        k.dep1();
                        break;
                    case 2:
                        k.dep2();
                        break;
                    default:
                        Console.WriteLine("Sorry you have entered a wrong input");
                        break;
                }
                Console.WriteLine("Do you want to continue this program? (y/n)");
                again = Convert.ToChar(Console.ReadLine());

            } while (again == 'y');

            Console.ReadKey();
        }
    }
}
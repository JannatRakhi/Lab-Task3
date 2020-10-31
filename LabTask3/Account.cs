using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask3
{
    public class Account
    {
        private String accName;
        private String acid;
        private int balance = 0;


        public void Deposit(int amount)
        {
            balance = balance + amount;
            Console.WriteLine("balance :" + balance);
            Console.WriteLine(" deposit amount " + amount);
        }
        public void Withdraw(int amount)
        {
            balance = balance - amount;
            Console.WriteLine("balance :" + balance);
            Console.WriteLine(" withdraw amount " + amount);
        }


        static void Main()
        {
            Account ob = new Account();
            ob.Deposit(40000);
            ob.Withdraw(20000);

            Course ob2 = new Course();
            ob2.set("OOP2", "2103", 3);
            ob2.ShowCourseInfo();

            Console.ReadLine();
        }
    }
}
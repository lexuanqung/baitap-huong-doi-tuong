using System;
using System.Collections.Generic;
using System.Text;

namespace bai_6
{
    class Account
    {
        private long number;
        private string name; 
        private double balance;
        private double RATE = 0.035;

        public Account()
        {
            number = 99999999;
            name = "uknow";
            balance = 50000;
        }

        public Account( string name,long number, double balance)
        {
            this.number = number;
            this.name = name;
            this.balance = balance;
        }

        public Account( string name,long number)
        {
            this.number = number;
            this.name = name;
        }
        public long getNumber() { return number; }
        public double getBalance() { return balance; }
         public bool deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                return true;
            }
            else return false;
        }
         public bool withdraw(double amount, double fee)
        {
            if (amount > 0 && amount + fee <= balance)
            {
                balance -= amount + fee;
                return true;
            }
            else return false;
        }
        public double addInterest()
        {
             return balance = balance + balance * RATE;
        }
        static public void printtitle()
        {
            Console.WriteLine("| {0,-15} | {1,-15} | {2,-15} | {3,-20} |",  "Name" ,"Number", "Balance", "Tien lai");
        }
        public void toString()
        {
            Console.WriteLine("| {0,-15} | {1,-15} | {2,-15} | {3,-20} |",  name, number, balance, addInterest());
        }
    }
}

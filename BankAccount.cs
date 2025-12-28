using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Encapuslation
{
    class BankAccount
    {
        // "Private" data members ( Data Hiding )
        private string accountHolder;
        private double balance;

        // Constructor
        public BankAccount(string name, double initialBalance)
        {
            accountHolder = name;
            balance = initialBalance;
        }

        // "Public" Method to Get Balance (Read-only Access)
        public double GetBalance()
        {
            return balance;
        }

        // "Public" Method to Deposit Cash
        public void Depost(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine(" Deposited Successfully!");
            }
            else
            {
                Console.WriteLine("Invalid Deposit Amount!");
            }
        }

        // "Public" Method to Withdraw Cash
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("WithDrawn Successfully!");
            }
            else
            {
                Console.WriteLine("Invalid Withdrawal Amount!");
            }
        }

            // "Public" Method to display Account info
        public void DisplayAccInfo()
        {
            Console.WriteLine($"Account Holder : {accountHolder}");
            Console.WriteLine($"Balance : {balance}");
        }

        }

    }


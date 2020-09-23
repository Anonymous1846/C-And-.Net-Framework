using System;
using System.Collections.Generic;
using System.Text;

namespace Lab
{
    class Bank
    {
        String name;
        private long accountNumber;//read-Only
        static double rate;
        private double balance;//read- Only
        String typeOfAccount;
        //Setting Properties for name and Account Type
       public String Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public String TypeOfAccount
        {
            get
            {
                return typeOfAccount;
            }
            set
            {
                typeOfAccount = value;
            }
        }
        //Default Constructor and Params
        public Bank()
        {
            name = null;
            accountNumber = 0;
            balance = 0;
            rate = 0;
            typeOfAccount = null;
        }
        public Bank(Bank bank)
        {
            name = bank.name;
            accountNumber = bank.accountNumber;
            typeOfAccount = bank.typeOfAccount;
            balance = bank.balance;
        }
        //Since balance and account number are read-only attributes they are passed on to constrctors
        public Bank(double bal,long ac_number)
        {
            balance = bal;
            accountNumber = ac_number;
            
        }
        public Double deposit(double amount)
        {
            balance += amount;
            return balance;
        }
        //used to set rate
        private static void setRate()
        {
            rate = 4.5;
        }
        public static void  displayRate()
        {
            setRate();
            Console.WriteLine("The Current Rate of Interest As Per RBI Regulations is {0} %",rate); 
        }
        public void withdraw(double amount_to_be_withdrawn)
        {
            double min = 500;
            if ((balance-amount_to_be_withdrawn)>min)
            {
                balance -= amount_to_be_withdrawn;
                Console.WriteLine("Rs.{0} withdrawn, Current Account Balance is {1}\n",amount_to_be_withdrawn,balance);
            }
            else
            {
                Console.WriteLine("Current Balance is {0},So After Withdrawl The Minimum Balance Won't Be Maintained\nSo Amount Couldn't Be Withdrawn\n",balance);
            }
        }
        public void displayDeatils()
        {
            Console.WriteLine("Account Holder Name: {0}\nBalance:{1}\nAccount Number:{2}\nAccount Type:{3}",name,balance,accountNumber,typeOfAccount); 
        }
        //Overall Function to test the bank class 
        public void TestBank()
        {
            Console.WriteLine("Enter Name :");
            String name = Console.ReadLine(), account_type;
            Bank bank = new Bank(550.9090, 1234567890);

            bank.Name = name;
            Console.WriteLine($"Hello {name},Please Enter The Account Type !");
            account_type = Console.ReadLine();
            bank.TypeOfAccount = account_type;
            int choice;
            do
            {
                Console.WriteLine("1)Deposit\n2)Withdraw\n3)Rate Of Interest As Per RBI Regulations\n4)Account Holder Credentials\n5)Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter The Amount To Deposit !");
                        double amount = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Amount Deposited :{amount},Closing Balance :{bank.deposit(amount)}\n");
                        break;
                    case 2:
                        Console.WriteLine("Enter The Amount To Withdraw !");
                        double amount_to_with = Convert.ToDouble(Console.ReadLine());
                        bank.withdraw(amount_to_with);
                        break;
                    case 3:
                        displayRate();
                        break;
                    case 4:
                        bank.displayDeatils();
                        break;
                    case 5:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Operation\n");
                        break;
                }

            } while (choice != 5);
        }
    }
   
}

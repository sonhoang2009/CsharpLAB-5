using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop8._2
{
    class FixedAccount : IAccount
    {


        private string _accountHolder;
        private long _accountNumber;
        private float _interestRate;
        private int _numberOfYears;
        private double _interestEarned;
        private double _totalBalance;
        private double _deposit;

        #region IAccount Members
        public bool AcceptDetails()
        {
            string input;
            Console.Write("Enter the name of the account holder: ");
            _accountHolder = Console.ReadLine();

        Number:
            Console.Write("Enter the account number: ");
            input = Console.ReadLine();
            _accountNumber = Convert.ToInt64(input);

            if (_accountNumber <= 0)
            {
                Console.WriteLine("Account number connot be zero of nagative \n");
                goto Number;
            }

        Amount:
            Console.Write("Enter the deposit amount ($) : ");
            _deposit = Convert.ToDouble(Console.ReadLine());

            if (_deposit <= 0)
            {
                Console.WriteLine("Invalid amount");
                goto Amount;
            }

            Console.WriteLine("Select the tenure for the deposit amount: ");
            Console.WriteLine("\nA. \t1 year \nB. \t3 years \nC. \t5 years ");
            Console.Write("\nChoose your option (A - C) : ");

            char choice = Convert.ToChar(Console.ReadLine());

            switch (choice)
            {
                case 'A':
                case 'a':
                    _numberOfYears = 1;
                    break;

                case 'B':
                case 'b':
                    _numberOfYears = 2;
                    break;

                case 'C':
                case 'c':
                    _numberOfYears = 3;
                    break;

            }
            return true;
        }

        public double CalculateInterest()
        {
            if (_deposit <= 5000)
            {
                if (_numberOfYears == 1)
                {
                    _interestRate = 3.5F;
                }
                else if (_numberOfYears == 3)
                {
                    _interestRate = 4;
                }
                else
                {
                    _interestRate = 4.5F;
                }
            }

            else if ((_deposit > 5000) && (_deposit <= 200000))
            {
                if (_numberOfYears == 1)
                {
                    _interestRate = 5;
                }
                else if (_numberOfYears == 3)
                {
                    _interestRate = 5.5F;
                }
                else
                {
                    _interestRate = 6;
                }
            }

            else
            {
                if (_numberOfYears == 1)
                {
                    _interestRate = 6.5F;
                }
                else if (_numberOfYears == 3)
                {
                    _interestRate = 7;
                }
                else
                {
                    _interestRate = 7.5F;
                }
            }
            return ((_deposit * _numberOfYears * _interestRate) / 100);
        }

        public double GetBalance()
        {
            _interestEarned = CalculateInterest();
            return (_deposit + _interestEarned);
        }

        public void Display()
        {
            _totalBalance = GetBalance();

            Console.WriteLine("\nAccount Holder: \t" + _accountHolder);
            Console.WriteLine("Account Number: \t" + _accountNumber);
            Console.WriteLine("Account deposited : \t" + _deposit + " $ ");
            Console.WriteLine("Interrest Rate: \t" + _interestRate + " % ");
            Console.WriteLine("Years of deposit : \t" + _numberOfYears);
            Console.WriteLine("Interesr Earned : \t" + _interestEarned + "$");
            Console.WriteLine("Maturity Amount : \t" + _totalBalance + " $ ");
        }

        #endregion
    }
}

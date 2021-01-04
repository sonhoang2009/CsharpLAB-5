using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLAB_5
{
    class Revenue : Expenditure
    {
      
        private double _balance;
        private double _totalIncome;

        internal override void AcceptDetails()
        {
            base.AcceptDetails();
            Console.WriteLine("\n");
            Console.Write("\nEnter the revenue earned annually : ");
            _totalIncome = Convert.ToDouble(Console.ReadLine());
        }

        internal override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("\nTotal Income\t\t\t" + _totalIncome);

            _balance = _totalIncome - TotalExpenses;

            if(_balance < 0)
            {
                Console.WriteLine("\nNet Looss : " + _balance + "\n");
            }
            else
            {
                Console.WriteLine("\nNet Profit :  " + _balance + "\n");
            }
        }

    }
}

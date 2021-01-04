using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLAB_5
{
    class Expenditure
    {
        protected string[] expenditureType = { "Maintenance", "Salary Paid", "Miscellaneous" };

        protected double[] expenditureAmount = new double[3];

        protected double TotalExpenses = 0;

        internal virtual void AcceptDetails()
        {
            Console.WriteLine("Enter the expenditure for the following heads : ");
            for(int i = 0; i< expenditureType.Length;i++)
            {
                Console.Write(expenditureType[i] + " : ");
                expenditureAmount[i] = Convert.ToDouble(Console.ReadLine());
                TotalExpenses += expenditureAmount[i];
            }
        }

        internal virtual void DisplayDetails()
        {
            Console.WriteLine("\n\nExpenditure Account ");
            Console.WriteLine("\nExpenditure Head\t\tAmount {$} ");
            Console.WriteLine("---------------------------------");

            for(int i = 0; i<expenditureType.Length; i++)
            {
                Console.WriteLine(expenditureType[i] + "\t\t\t" + expenditureAmount[i]);
            }

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Total Expenditure\t\t" + TotalExpenses);
        }

    }
}

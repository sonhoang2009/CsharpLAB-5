using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop8._1
{
    class SavingTest
    {
        static void Main(string[] args)
        {
            SavingAccount objSavings = new SavingAccount();

            if (objSavings.AcceptDetails())
            {
                objSavings.Display();
            }
            else
            {
                return;
            }
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop8._2
{
    class FixedAccountTest

    {
        static void Main(string[] args)
        {
            FixedAccount objFixed = new FixedAccount();
            Console.WriteLine("\t\t\tFIXED ACCOUNT DETAILS \n");

            char choice;

            do
            {
                if (!objFixed.AcceptDetails())
                {
                    return;
                }
                else
                {
                    objFixed.Display();
                }

                Console.Write("\nDo you wish to continue [ Y | N]: ");
                choice = Convert.ToChar(Console.ReadLine());
                Console.WriteLine();

            }
            while ((choice == 'y') || (choice == 'Y'));


        }
    }
}

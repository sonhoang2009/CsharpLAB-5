using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop7._2
{
    class Worker
    {
        private string _workerName;

        private int _workerID;

        private string _designation;

        private double _salary;

        private double _amount;

        private int _yearOfService;

        Appraisal objAppraisai = new Appraisal();


        public bool InputDetails()
        {
            Console.Write("Enter the woker name : ");
            _workerName = Console.ReadLine();
            Console.Write("Enter the worker ID : ");
            _workerID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nSelect the designation (1-3) : ");
            Console.WriteLine("1 - Manager");
            Console.WriteLine("2 - Engineer");
            Console.WriteLine("3 - Techinician");
            Console.Write("Enter your choice : ");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();

            switch (value)
            {
                case 1:
                    _designation = "Manager";
                    _salary = 5000;
                    break;

                case 2:
                    _designation = "Engineer";
                    _salary = 4000;
                    break;

                case 3:
                    _designation = "Technician";
                    _salary = 3000;
                    break;

                default:
                    Console.WriteLine("Invalid option selected");
                    break;
            }

        Service:
            Console.WriteLine("Enter the years of service : ");
            _yearOfService = Convert.ToInt32(Console.ReadLine());

            if(_yearOfService < 0)
            {
                Console.WriteLine("Years of service cannot be negative ");
                goto Service;
            }
            return true;
        }

        public void DisplayDetails()
        {
            _amount = objAppraisai.CalculateBonus(_designation, _yearOfService, _salary);

            Console.WriteLine("\n\nEmployee Name : " + _workerName);
            Console.WriteLine("Employee ID : " + _workerID);
            Console.WriteLine("Designation : " + _designation);
            Console.WriteLine("Salary : " + _salary);
            Console.WriteLine("Bonus: " +_amount);
            Console.WriteLine("Total income earned  : " + (_amount+_salary));
            Console.ReadKey();
        }

 
    }
}

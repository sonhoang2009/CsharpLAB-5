using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop7._2
{
    public sealed class Appraisal
    {
        private double _bonus;

        public double CalculateBonus(string designation, int tenure , double salary)
        {
            if(designation == "Manager")
            {
                if (tenure <=5)
                {
                    _bonus = salary * 1.5;
                }
                else
                {
                    _bonus = salary * 2;
                }
                if(designation == "Engineer")
                {
                    if(tenure <= 5)
                    {
                        _bonus = salary;
                            }
                    else
                    {
                        _bonus = salary * 2;
                    }
                }
                if(designation == "TEchnician")
                {
                    if(tenure <=3)
                    {
                        _bonus = salary * 0.2;
                    }
                    else if(tenure > 3 && tenure <=5)
                    {
                        _bonus = salary * 0.5;
                    }
                    else
                    {
                        _bonus = salary * 2;
                    }
                }
            }
            return _bonus;
            Console.ReadKey();
        }

    }
}

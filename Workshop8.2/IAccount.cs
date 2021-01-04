using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop8._2
{
    public interface IAccount
    {
        bool AccpetDetails();
        double CalculateInterest();
        double GetBalance();
        void Display();

    }
}

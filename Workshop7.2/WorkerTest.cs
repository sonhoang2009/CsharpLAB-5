using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop7._2
{
    class WorkerTest
    {
        static void main(string [] args)
        {
            Worker objWorker = new Worker();
            if(objWorker.InputDetails())
            {
                objWorker.DisplayDetails();
                Console.ReadKey();
            }
            
        }
    }
}

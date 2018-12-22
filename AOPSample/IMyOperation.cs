using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPSample
{
    public class MyOperation:IMyOperation
    {
        void IMyOperation.DoIt()
        {
            Console.WriteLine("this is main block of code");
        }
    }
}

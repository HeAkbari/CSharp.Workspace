using Microsoft.Practices.Unity.InterceptionExtension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPSample
{
    public class LogHandler : ICallHandler
    {
        public int Order{get; set;}

        public IMethodReturn Invoke(IMethodInvocation input, GetNextHandlerDelegate getNext)
        {
            Logger.WriteToFile(input.MethodBase.Name);
            var metodReturn = getNext()(input,getNext);
            return metodReturn;
        }
    }
}

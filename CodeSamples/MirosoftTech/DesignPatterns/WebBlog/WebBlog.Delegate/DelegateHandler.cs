using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBlog.Delegate
{
    internal class DelegateHandler
    {
        public void ExecuteDelegate(Action<IDelegateTaker> myDelegate)
        {
            var delegateTaker = new DelegateTacker() { PrintThis = "Hello From Delegate" };
            myDelegate(delegateTaker);
        }
        public void PrintMessage()
        {
            ExecuteDelegate(delegateTaker =>
            {
                delegateTaker.PrintThis();
            });
        }
    }
}

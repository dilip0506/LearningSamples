using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebBlog.Delegate
{
    public static class TestRunner
    {
        public static void Run()
        {
            var delegateHandler = new DelegateHandler();
            delegateHandler.PrintMessage();
        }
    }
}

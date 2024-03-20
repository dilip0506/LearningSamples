using System;
using System.Diagnostics;

namespace MultiThreading
{

    public class AsyncWithDelegate
    {
        //Async with Delegate is not supported in .Net Core
        //use Task
        private void DoWork()
        {
            Debug.WriteLine("Hello I am Invoked");
        }

        delegate void DoWorkDelegate();


        public void AsyncCall()
        {
            DoWorkDelegate doWorkDelegate = DoWork;
            IAsyncResult doWorkResult = doWorkDelegate.BeginInvoke(TakeRest, doWorkDelegate);
            doWorkDelegate.EndInvoke(doWorkResult);
            Debug.WriteLine("End Of Main Thread");
        }

        public void TakeRest(IAsyncResult ar)
        {
            var doWorkDelegate = ar.AsyncState as DoWorkDelegate;
            doWorkDelegate.EndInvoke(ar);
            Debug.WriteLine("I did a good work today");
        }
    }
}

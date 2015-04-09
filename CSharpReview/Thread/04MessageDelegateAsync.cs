using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;

namespace CSharpReview.ThreadFolder
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine(string.Format("Without parameter, CurrentId {0} is begin.", Thread.CurrentThread.ManagedThreadId));
    //        HelloMessage hm = new HelloMessage(new Message().HelloMessage);
    //        hm.BeginInvoke(new AsyncCallback(CallbackWithouParameter), new Person() { Name = "Liu", Age = 33 });
    //        Console.WriteLine(string.Format("Without parameter, CurrentId {0} end.", Thread.CurrentThread.ManagedThreadId));

    //        Console.WriteLine(string.Format("With parameter, CurrentId {0} is begin.", Thread.CurrentThread.ManagedThreadId));
    //        ObjctHelloMessage ohm = new ObjctHelloMessage(new Message().HelloMessage);
    //        ohm.BeginInvoke(new Person() { Name = "Nate", Age = 33 }, x =>
    //        {
    //            while (!x.AsyncWaitHandle.WaitOne(300))
    //            {
    //                Thread.Sleep(300);
    //            }
    //            Console.WriteLine(ohm.EndInvoke(x));
    //        }
    //        , null);
    //        Console.WriteLine(string.Format("With parameter, CurrentId {0} end.", Thread.CurrentThread.ManagedThreadId));

    //        Console.ReadLine();//must have this statement,otherwise will exit immediately because ThreadPool are create backgroud thread.
    //    }

    //    static void CallbackWithouParameter(IAsyncResult ar)
    //    {
    //        while (!ar.IsCompleted)
    //        {
    //            Thread.Sleep(300);
    //        }
    //        AsyncResult result = (AsyncResult)ar;
    //        HelloMessage myDelegate = (HelloMessage)result.AsyncDelegate;
    //        Person p = (Person)result.AsyncState;
    //        Console.WriteLine(myDelegate.EndInvoke(result));
    //        Console.WriteLine(string.Format("{0}'s age is {1}, it pass from the invoke method", p.Name, p.Age));
    //    }
    //}
}

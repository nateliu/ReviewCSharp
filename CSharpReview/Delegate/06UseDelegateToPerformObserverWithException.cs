using CSharpReview.Delegate.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpReview.Delegate.UseDelegateToPerformObserverWithException
{
    public delegate string NumberChangedEventHandler(int count);

    public class Publishser
    {
        public event NumberChangedEventHandler NumberChanged;

        public void DoNumberChanged(int count)
        {
            if (null == NumberChanged) return;

            System.Delegate[] delArray = NumberChanged.GetInvocationList();
            foreach (System.Delegate dg in delArray)
            {
                try
                {
                    NumberChangedEventHandler method = (NumberChangedEventHandler)dg;
                    string rtn = method(count);
                    Console.WriteLine(rtn);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Publishser pub = new Publishser();
    //        Subscriber1 sub1 = new Subscriber1();
    //        SubscriberWithException2 sub2 = new SubscriberWithException2();
    //        Subscriber3 sub3 = new Subscriber3();

    //        pub.NumberChanged += sub1.OnNumberChanged;
    //        pub.NumberChanged += sub2.OnNumberChanged;
    //        pub.NumberChanged += sub3.OnNumberChanged;

    //        pub.DoNumberChanged(100);

    //        Console.ReadLine();
    //    }
    //}
}

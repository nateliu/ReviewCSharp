using CSharpReview.Delegate.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpReview.Delegate.UseDelegateToPerformObserverWithTimeOut
{
    public delegate string NumberChangedEventHandler(int count);

    public class Publishser
    {
        public event NumberChangedEventHandler NumberChanged;

        public void DoNumberChanged(int count)
        {
            Console.WriteLine("do number change begin");
            if (null == NumberChanged) return;

            System.Delegate[] delArray = NumberChanged.GetInvocationList();
            foreach (System.Delegate dg in delArray)
            {
                try
                {
                    NumberChangedEventHandler method = (NumberChangedEventHandler)dg;
                    method.BeginInvoke(count, x => 
                                                {
                                                    while (!x.IsCompleted) 
                                                        System.Threading.Thread.Sleep(1);
                                                    Console.WriteLine(method.EndInvoke(x));
                                                }, null);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine("do number change end.");
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Publishser pub = new Publishser();
    //        SubscriberWithTimeOut1 sub1 = new SubscriberWithTimeOut1();
    //        SubscriberWithTimeOut2 sub2 = new SubscriberWithTimeOut2();
    //        Subscriber3 sub3 = new Subscriber3();

    //        pub.NumberChanged += sub1.OnNumberChanged;
    //        pub.NumberChanged += sub2.OnNumberChanged;
    //        pub.NumberChanged += sub3.OnNumberChanged;

    //        pub.DoNumberChanged(100);

    //        Console.ReadLine();
    //    }
    //}
}

using CSharpReview.Delegate.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpReview.Delegate.UseDelegateToPerformObserverWithEventAccessor
{
    public delegate string NumberChangedEventHandler(int count);

    public class Publishser
    {
        private NumberChangedEventHandler numberChanged;

        public event NumberChangedEventHandler NumberChanged
        {
            add { numberChanged = value; }
            remove { numberChanged -= value; }
        }

        public void DoNumberChanged(int count)
        {
            if (null == numberChanged) return;

            System.Delegate[] delArray = numberChanged.GetInvocationList();
            foreach (System.Delegate dg in delArray)
            {
                Console.WriteLine(dg.DynamicInvoke(count));
            }
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Publishser pub = new Publishser();
    //        Subscriber1 sub1 = new Subscriber1();
    //        Subscriber2 sub2 = new Subscriber2();
    //        Subscriber3 sub3 = new Subscriber3();

    //        pub.NumberChanged += sub1.OnNumberChanged;
    //        pub.NumberChanged += sub2.OnNumberChanged;
    //        pub.NumberChanged += sub3.OnNumberChanged;

    //        pub.DoNumberChanged(100);

    //        Console.ReadLine();
    //    }
    //}
}

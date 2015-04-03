using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpReview.Delegate.Common
{
    public class Subscriber1
    {
        public string OnNumberChanged(int count)
        {
            return string.Format("Subscriber1 notified: count = {0}", count);
        }
    }

    public class SubscriberWithTimeOut1
    {
        public string OnNumberChanged(int count)
        {
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));
            return string.Format("Subscriber1 has sleeped 1 seconds,and notified: count = {0}", count);
        }
    }

    public class Subscriber2
    {
        public string OnNumberChanged(int count)
        {
            return string.Format("Subscriber2 notified: count = {0}", count);
        }
    }

    public class SubscriberWithException2
    {
        public string OnNumberChanged(int count)
        {
            throw new Exception("Subscriber2 has error.");
        }
    }

    public class SubscriberWithTimeOut2
    {
        public string OnNumberChanged(int count)
        {
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(2));
            return string.Format("Subscriber2 has sleeped 2 seconds,and notified: count = {0}", count);
        }
    }

    public class Subscriber3
    {
        public string OnNumberChanged(int count)
        {
            return string.Format("Subscriber3 notified: count = {0}", count);
        }
    }
}

using CSharpReview.Delegate.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpReview.Delegate.UseDelegateWithEvent
{
    public class SpeakerManager
    {
        public delegate void GreetingDelegate(string name);
        public event GreetingDelegate OngreetingDelegate;

        public void SpeakeGreeting(string name)
        {
            if (null != OngreetingDelegate)
            {
                OngreetingDelegate(name);
            }
        }
    }   

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        SpeakerManager manager = new SpeakerManager(); 
    //        //manager.OngreetingDelegate = ChineseSpeaker.Greeting;    //error, but OnGreetingDelegate is public, why??    
    //        manager.OngreetingDelegate += ChineseSpeaker.Greeting;
    //        manager.OngreetingDelegate += EnglishSpeaker.Greeting;
    //        manager.SpeakeGreeting("Nate Liu");
    //        Console.ReadLine();
    //    }
    //}
}

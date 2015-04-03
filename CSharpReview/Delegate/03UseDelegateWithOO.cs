using CSharpReview.Delegate.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpReview.Delegate.UseDelegateWithOO
{
    public class SpeakerManager
    {
        public delegate void GreetingDelegate(string name);
        public GreetingDelegate greetingDelegate;
        public void SpeakeGreeting(string name)
        {
            if (null != greetingDelegate)
            {
                greetingDelegate(name);
            }
        }
    }


    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        SpeakerManager manager = new SpeakerManager();
    //        manager.greetingDelegate += ChineseSpeaker.Greeting;//this also working fine??
    //        manager.greetingDelegate = ChineseSpeaker.Greeting;
    //        manager.greetingDelegate += EnglishSpeaker.Greeting;
    //        manager.SpeakeGreeting("Nate Liu");
    //        Console.ReadLine();
    //    }
    //}
}

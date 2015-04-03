using CSharpReview.Delegate.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpReview.Delegate.UseDelegate
{
    public class SpeakerManager
    {
        public delegate void GreetingDelegate(string name);

        public void SpeakeGreeting(string name, GreetingDelegate greetingDelegate)
        {
            greetingDelegate(name);
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        SpeakerManager manager = new SpeakerManager();
    //        manager.SpeakeGreeting("Nate Liu", ChineseSpeaker.Greeting);
    //        manager.SpeakeGreeting("Nate Liu", EnglishSpeaker.Greeting);
    //        Console.ReadLine();
    //    }
    //}
}

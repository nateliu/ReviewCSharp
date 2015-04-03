using CSharpReview.Delegate.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpReview.Delegate.Previous
{
    public class SpeakerManager
    {
        public void SpeakeGreeting(string name,Language language)
        {
            switch (language)
            {
                case Language.Chinese:
                    ChineseSpeaker.Greeting(name);
                    break;
                case Language.English:
                    EnglishSpeaker.Greeting(name);
                    break;
                default:
                    break;
            }
        }
    }

   public enum Language
    {
        Chinese,
        English
    }

   //class Program
   //{
   //    static void Main(string[] args)
   //    {
   //        SpeakerManager manger = new SpeakerManager();
   //        manger.SpeakeGreeting("Nate Liu", Language.Chinese);
   //        manger.SpeakeGreeting("Nate Liu", Language.English);
   //        Console.ReadLine();
   //    }
   //}
}

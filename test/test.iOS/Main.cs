using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace test.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");
            App.ScreenHeight = (int)UIScreen.MainScreen.Bounds.Height;
            App.ScreenWidth = (int)UIScreen.MainScreen.Bounds.Width;
            UIApplication.SharedApplication.StatusBarStyle = UIStatusBarStyle.Default;

        }
    }
}

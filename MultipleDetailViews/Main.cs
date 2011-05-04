
using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MultipleDetailViews
{
  public class Application
  {
    static void Main (string[] args)
    {
      UIApplication.Main (args);
    }
  }

  // The name AppDelegate is referenced in the MainWindow.xib file.
  public partial class AppDelegate : UIApplicationDelegate
  {
    // This method is invoked when the application has loaded its UI and its ready to run
    public override bool FinishedLaunching (UIApplication app, NSDictionary options)
    {
      this.SplitViewController.Delegate = new SplitDelegate ();
      
      window.AddSubview (SplitViewController.View);
      
      window.MakeKeyAndVisible ();
      
      return true;
    }
  }
}
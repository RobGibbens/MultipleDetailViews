
using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MultipleDetailViews
{
  public partial class FirstDetailView : UIViewController, ISubstitutableDetailViewController
  {
    
    
    // The IntPtr and initWithCoder constructors are required for controllers that need 
    // to be able to be created from a xib rather than from managed code

    public FirstDetailView (IntPtr handle) : base(handle)
    {
      Initialize ();
    }

    [Export("initWithCoder:")]
    public FirstDetailView (NSCoder coder) : base(coder)
    {
      Initialize ();
    }

    public FirstDetailView () : base("FirstDetailView", null)
    {
      Initialize ();
    }

    void Initialize ()
    {
    }
    
  }
}
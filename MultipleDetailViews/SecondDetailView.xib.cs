using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MultipleDetailViews
{
  public partial class SecondDetailView : UIViewController, ISubstitutableDetailViewController
  {
    // The IntPtr and initWithCoder constructors are required for controllers that need 
    // to be able to be created from a xib rather than from managed code
  
    public SecondDetailView (IntPtr handle) : base(handle)
    {
      Initialize ();
    }

    [Export("initWithCoder:")]
    public SecondDetailView (NSCoder coder) : base(coder)
    {
      Initialize ();
    }

    public SecondDetailView () : base("SecondDetailView", null)
    {
      Initialize ();
    }

    void Initialize ()
    {
    }
  }
}
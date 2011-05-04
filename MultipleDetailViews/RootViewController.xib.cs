
using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MultipleDetailViews
{
  public partial class RootViewController : UITableViewController
  {
    #region Constructors

    // The IntPtr and initWithCoder constructors are required for controllers that need 
    // to be able to be created from a xib rather than from managed code

    public RootViewController (IntPtr handle) : base(handle)
    {
      Initialize ();
    }

    [Export("initWithCoder:")]
    public RootViewController (NSCoder coder) : base(coder)
    {
      Initialize ();
    }

    public RootViewController () : base("RootViewController", null)
    {
      Initialize ();
    }

    void Initialize ()
    {
    }
    
    #endregion
    
    
    
  }
}


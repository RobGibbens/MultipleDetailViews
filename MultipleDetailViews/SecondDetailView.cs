using System;
using MonoTouch.UIKit;
namespace MultipleDetailViews
{
  public partial class SecondDetailView
  {
    UIPopoverController _popOverController;
    UIBarButtonItem _rootPopoverButtonItem;

    public UIPopoverController PopOverController {
      get {
        return this._popOverController;
      }
      set {
        _popOverController = value;
      }
    }
    
    public UIBarButtonItem RootPopoverButtonItem {
      get {
        return this._rootPopoverButtonItem;
      }
      set {
        _rootPopoverButtonItem = value;
      }
    }   
  
    #region View lifecycle
    public override void ViewDidUnload ()
    {
      base.ViewDidUnload ();
      this.navigationBar = null;
    }
    #endregion
    
    #region Managing the popover
    
    public void ShowRootPopoverButtonItem (UIBarButtonItem barButtonItem)
    {
      // Add the popover button to the left navigation item.
      this.navigationBar.TopItem.SetLeftBarButtonItem(barButtonItem, false);
    }

    public void InvalidateRootPopoverButtonItem (UIBarButtonItem barButtonItem)
    {
      // Remove the popover button.
      this.navigationBar.TopItem.SetLeftBarButtonItem(null, false);
    }
    #endregion
    
    #region Rotation Support
    public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
    {
      return true;
    }
    #endregion

  }
}


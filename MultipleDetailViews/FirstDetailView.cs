using System;
using MonoTouch.UIKit;
using System.Linq;

namespace MultipleDetailViews
{
  public partial class FirstDetailView
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
      this.toolbar = null;
    }
    #endregion

    #region Managing the popover

    public void ShowRootPopoverButtonItem (UIBarButtonItem barButtonItem)
    {
      // Add the popover button to the toolbar.
      
      var itemsArray = this.toolbar.Items.ToList();
      //NSMutableArray *itemsArray = [toolbar.items mutableCopy];
      
      if (itemsArray.Count == 0)
      {
        itemsArray.Insert(0, barButtonItem);
      }
      else
      {
        itemsArray[0] = barButtonItem;
      }
      //[itemsArray insertObject:barButtonItem atIndex:0];
      
      this.toolbar.SetItems (itemsArray.ToArray(), false);
      //[toolbar setItems:itemsArray animated:NO];
      
      itemsArray = null;
      //[itemsArray release];      
    }

    public void InvalidateRootPopoverButtonItem (UIBarButtonItem barButtonItem)
    {
      // Remove the popover button from the toolbar.
      var itemsArray = this.toolbar.Items.ToList ();
      //NSMutableArray *itemsArray = [toolbar.items mutableCopy];
      
      itemsArray.Remove (barButtonItem);
      //[itemsArray removeObject:barButtonItem];
      
      this.toolbar.SetItems (itemsArray.ToArray (), false);
      //[toolbar setItems:itemsArray animated:NO];
      
      itemsArray = null;
      //[itemsArray release];      
    }

    #endregion

    #region Rotation support
    public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
    {
      //return base.ShouldAutorotateToInterfaceOrientation (toInterfaceOrientation);
      return true;
    }
    #endregion      
    
  }
}


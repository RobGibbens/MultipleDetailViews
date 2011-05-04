using System;
using MonoTouch.UIKit;

namespace MultipleDetailViews
{
  public class SplitDelegate : UISplitViewControllerDelegate
  {

    public override void WillHideViewController (UISplitViewController svc, 
                                                 UIViewController aViewController, 
                                                 UIBarButtonItem barButtonItem, 
                                                 UIPopoverController pc)
    {
      barButtonItem.Title = "Root View Controller";
      
      var detailViewController = svc.ViewControllers[1] as ISubstitutableDetailViewController;

      detailViewController.PopOverController = pc;

      detailViewController.RootPopoverButtonItem = barButtonItem;

      detailViewController.ShowRootPopoverButtonItem(detailViewController.RootPopoverButtonItem);
    }

    public override void WillShowViewController (UISplitViewController svc, UIViewController aViewController, UIBarButtonItem button)
    {
     var detailViewController = svc.ViewControllers[1] as ISubstitutableDetailViewController;

      detailViewController.InvalidateRootPopoverButtonItem(detailViewController.RootPopoverButtonItem);

      detailViewController.PopOverController = null;

      detailViewController.RootPopoverButtonItem = null;
    }
    
  }
}

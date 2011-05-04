using System;
using MonoTouch.UIKit;

namespace MultipleDetailViews
{
    public interface ISubstitutableDetailViewController
    {
      UIPopoverController PopOverController { get; set; }
      UIBarButtonItem RootPopoverButtonItem { get; set;}    
    
      void ShowRootPopoverButtonItem(UIBarButtonItem barButtonItem);
      void InvalidateRootPopoverButtonItem(UIBarButtonItem barButtonItem);
    }
}
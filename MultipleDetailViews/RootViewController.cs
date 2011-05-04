using System;
using MonoTouch.UIKit;
using System.Drawing;
using MonoTouch.Foundation;
using System.Collections.Generic;

namespace MultipleDetailViews
{
  public partial class RootViewController : UITableViewController
  {
    static NSString kCellIdentifier = new NSString ("MyIdentifier");

    #region View lifecycle
    public override void ViewDidLoad ()
    {
      base.ViewDidLoad ();
      TableView.Delegate = new TableDelegate (this);
      TableView.DataSource = new DataSource (this);
      this.ContentSizeForViewInPopover = new SizeF (310.0f, (this.TableView.RowHeight * 2.0f));
    }

    public override void ViewDidUnload ()
    {
      base.ViewDidUnload ();
    }
    #endregion

    #region Rotation Support
    public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
    {
      return true;
    }
    #endregion

    #region Table view data source
    class DataSource : UITableViewDataSource
    {
      RootViewController _rootViewController;

      public DataSource (RootViewController rootViewController)
      {
        this._rootViewController = rootViewController;
      }

      public override int RowsInSection (UITableView tableView, int section)
      {
        // Two sections, one for each detail view controller.
        return 2;
      }

      public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
      {
        // Dequeue or create a cell of the appropriate type.
        var cell = tableView.DequeueReusableCell (kCellIdentifier);
        if (cell == null) {
          cell = new UITableViewCell (UITableViewCellStyle.Default, kCellIdentifier);
        }
        
        // Set appropriate labels for the cells.
        if (indexPath.Row == 0)
        {
          cell.TextLabel.Text = @"First Detail View Controller";
        }
        else
        {
          cell.TextLabel.Text = @"Second Detail View Controller";
          
        }
        
        return cell;
      }
    }

    class TableDelegate : UITableViewDelegate
    {
      RootViewController _rootViewController;

      public TableDelegate (RootViewController rootViewController)
      {
        this._rootViewController = rootViewController;
      }

      public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
      {
        int row = indexPath.Row;
        ISubstitutableDetailViewController detailViewController = null;
        
        if (row == 0)
        {
          FirstDetailView newDetailViewController = new FirstDetailView();
          detailViewController = newDetailViewController;
        }

        if (row == 1)
        {
          SecondDetailView newDetailViewController = new SecondDetailView();
          detailViewController = newDetailViewController;
        }
        
        var existingVC = _rootViewController.SplitViewController.ViewControllers[1] as ISubstitutableDetailViewController;
        detailViewController.RootPopoverButtonItem = existingVC.RootPopoverButtonItem;
        detailViewController.PopOverController = existingVC.PopOverController;
        
        
        // Update the split view controller's view controllers array.
        var viewControllers = new UIViewController[] { 
            _rootViewController.NavigationController, 
            detailViewController as UIViewController 
          };
        _rootViewController.SplitViewController.ViewControllers = viewControllers;
        

        UINavigationController parentViewController = _rootViewController.ParentViewController as UINavigationController;
        if (detailViewController.RootPopoverButtonItem != null)
        {
          detailViewController.ShowRootPopoverButtonItem( detailViewController.RootPopoverButtonItem);
        }
        if (detailViewController.PopOverController != null)
        {
          detailViewController.PopOverController.Dismiss(true);
        }
        
      }
    }
    #endregion
    
    
  }
  
}

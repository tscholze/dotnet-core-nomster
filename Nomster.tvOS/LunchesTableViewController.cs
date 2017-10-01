using System;
using Nomster.Core.ViewModel;
using UIKit;

/*
 * CAUTION
 * 
 * This sample is not really working at the moment. I've to investigate and improve my skills to
 * continue my work on the tvOS example
 * 
 * CAUTION
 */


namespace Nomster.tvOS
{
    public partial class LunchesTableViewController : UITableViewController
    {
        #region Private members 

        MainViewModel viewModel;

        #endregion

        #region Constructors

        public LunchesTableViewController() : base("LunchesTableViewController", null)
        {

        }

        public LunchesTableViewController(IntPtr handle) : base(handle)
        {
            
        }

        #endregion

        #region View life cycle

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            viewModel = new MainViewModel();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

		#endregion

		/*
        #region UITableViewDataSource 

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return viewModel.Lunches.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
        {
            var cell = new UITableViewCell(UITableViewCellStyle.Subtitle, "lunchCell");
            var lunch = viewModel.Lunches[indexPath.Row];

            cell.TextLabel.Text = lunch.Title;
            cell.DetailTextLabel.Text = String.Format("{0:HH:mm}", lunch.OfficeLeftDate);

            return cell;
        }

        #endregion
        */
	}
}


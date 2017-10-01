using AppKit;
using Foundation;

using Nomster.Core;

using Xamarin.Forms;
using Xamarin.Forms.Platform.MacOS;

namespace Nomster.macOS
{
    [Register("AppDelegate")]
    public class AppDelegate : FormsApplicationDelegate
    {
        #region Private members 

        NSWindow window;

        #endregion

        public AppDelegate()
        {
            // Setup the frame
            var style = NSWindowStyle.Closable | NSWindowStyle.Resizable | NSWindowStyle.Titled;
            var rect = new CoreGraphics.CGRect(200, 1000, 360, 350);

            // Setup the window
            window = new NSWindow(rect, style, NSBackingStore.Buffered, false);
            window.Title = "Nomster for macOS";
            window.TitleVisibility = NSWindowTitleVisibility.Visible;
        }

        #region App life cycle

        public override void DidFinishLaunching(NSNotification notification)
        {
			Forms.Init();
			LoadApplication(new App());
			base.DidFinishLaunching(notification);
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }

		#endregion

		#region Overwrittings

		public override NSWindow MainWindow
		{
			get { return window; }
		}

        #endregion
    }
}

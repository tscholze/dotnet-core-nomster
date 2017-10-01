using Nomster.Core.Views;

using Xamarin.Forms;

namespace Nomster.Core
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // Set the main (initial) page content
            MainPage = new MainPage();
        }
    }
}

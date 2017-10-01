using Xamarin.Forms;

using Nomster.Core.ViewModel;

namespace Nomster.Core.Views
{
	public partial class MainPage : ContentPage
	{
		#region Private members 

		MainViewModel viewModel;

		#endregion

		#region Constructor

		public MainPage()
		{
			InitializeComponent();

			viewModel = new MainViewModel();
			BindingContext = viewModel;
		}

		#endregion

		#region Page event handler

		void Handle_Clicked(object sender, System.EventArgs e)
		{
            Navigation.PushModalAsync(new NewLunchPage());
		}

		#endregion
	}
}
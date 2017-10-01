using Nomster.Core.ViewModel;

using Xamarin.Forms;

namespace Nomster.Core.Views
{
	public partial class NewLunchPage : ContentPage
	{
		#region Private members

		NewLunchViewModel viewModel;

		#endregion

		#region Constructor

		public NewLunchPage()
		{
			InitializeComponent();

			viewModel = new NewLunchViewModel();
			BindingContext = viewModel;
		}

		#endregion

		#region Page event handler

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PopModalAsync();
		}

		#endregion
	}
}

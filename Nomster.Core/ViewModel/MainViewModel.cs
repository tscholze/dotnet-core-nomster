using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

using Nomster.Core.Helper;
using Nomster.Core.Model;
using Nomster.Core.Service;

using Xamarin.Forms;

namespace Nomster.Core.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        #region Private constants

        const bool useServerDatasource = false;

        #endregion

        #region Observable members 

        /// <summary>
        /// Gets or sets all available Lunches
        /// </summary>
        /// <value>All available lunches</value>
        public ObservableCollection<Lunch> Lunches { get; set; }

        /// <summary>
        /// Gets or sets the command to retrieve all available lunches
        /// </summary>
        /// <value>Command to retrieve all available lunches</value>
        public Command GetLunchesCommand { get; set; }

        /// <summary>
        /// Gets or sets the command to join an exising lunch
        /// </summary>
        /// <value>Command to join an exising lunch</value>
        public Command JoinLunchCommand { get; set; }

        bool isBusy;

        /// <summary>
        /// Indicates wether the page is busy requesting data or not.
        /// </summary>
        /// <value><c>true</c> if is busy; otherwise, <c>false</c>.</value>
        public bool IsBusy
        {
            get { return isBusy; }
            set
            {
                isBusy = value;
                OnPropertyChanged();

                GetLunchesCommand.ChangeCanExecute();
                JoinLunchCommand.ChangeCanExecute();
            }
        }

        /// <summary>
        /// Pages title with short read information
        /// </summary>
        /// <value>The title.</value>
        public string Title
        {
            get
            {
                return DateTime.Now.ToString("dd.MM.yyyy");
            }
        }

        #endregion

        #region Constructor

        public MainViewModel()
        {
            Lunches = MockHelper.MockLunches();
            GetLunchesCommand = new Command(async () => await GetLunches());
            JoinLunchCommand = new Command(async (object lunchGuid) => await JoinLunch(lunchGuid));
        }

        #endregion

        #region Command handler

        /// <summary>
        /// Retrieves all available lunches from the datasource
        /// </summary>
        /// <returns>Retrieves all available lunches</returns>
        async Task GetLunches()
        {
            if (IsBusy)
                return;

            Exception error = null;

            try
            {
                IsBusy = true;
                Lunches.Clear();

#pragma warning disable RECS0110
                var lunches = useServerDatasource ? await DependencyService.Get<AzureService>().GetLunches() : MockHelper.MockLunches();
#pragma warning restore RECS0110

                foreach (var lunch in MockHelper.MockLunches())
                {
                    Lunches.Add(lunch);
                }
            }
            catch (Exception e)
            {
                error = e;
            }
            finally
            {
                isBusy = false;
            }

            if (error != null)
                await Application.Current.MainPage.DisplayAlert("Error!", error.Message, "OK");
        }

        /// <summary>
        /// Adds new anonymous attendee to the related lunch object
        /// </summary>
        /// <returns>The lunch.</returns>
        /// <param name="lunchGuid">Lunch GUID.</param>
        async Task JoinLunch(object lunchGuid)
        {
            if (IsBusy)
                return;

            isBusy = true;

            // Update the related lunch object
            var guid = (string)lunchGuid;
            var lunch = Lunches.Where(l => l.Id == guid).First();
            var index = Lunches.IndexOf(lunch);

            lunch.NumberOfAttendees += 1;
            Lunches[index] = lunch;

            // Trigger sync
            // .. not yet implemented

            isBusy = false;
        }

        #endregion
    }
}

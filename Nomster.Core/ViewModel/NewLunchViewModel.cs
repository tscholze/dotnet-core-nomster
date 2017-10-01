using System;

using Nomster.Core.Model;

using Xamarin.Forms;

namespace Nomster.Core.ViewModel
{
    public class NewLunchViewModel : BaseViewModel
    {
        #region Observable members 

        Lunch lunch;

        /// <summary>
        /// Gets or sets the new lunch.
        /// </summary>
        /// <value>The lunch.</value>
        public Lunch Lunch
        {
            get 
            {
                return lunch;
            }

            set
            {
                lunch = value;
                OnPropertyChanged("Lunch");
            }
        }

        /// <summary>
        /// Triggeres an add to list and a modal page close to navigate back 
        /// to the main page.
        /// </summary>
        /// <value>The add lunch command.</value>
        public Command AddLunchCommand { get; set; }

        #endregion

        #region Constructors

        public NewLunchViewModel()
        {
            Lunch = new Lunch() { Id = Guid.NewGuid().ToString(), Title = String.Empty, OfficeLeftDate = DateTime.Now, NumberOfAttendees = 1 };
            AddLunchCommand = new Command((obj) => AddLunch());
        }

        #endregion

        #region Command handler

        /// <summary>
        /// AddLunchCommand handler
        /// As dummy method, it closes the modal page.
        /// </summary>
        void AddLunch()
        {

            // Close modal page
            Application.Current.MainPage.Navigation.PopModalAsync();
        }

        #endregion
    }
}

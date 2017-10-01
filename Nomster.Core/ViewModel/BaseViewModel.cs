using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Nomster.Core.ViewModel
{
    /// <summary>
    /// Base for all other viewmodels. It implements the
    /// <see cref="INotifyPropertyChanged"/> interface.
    /// </summary>
    public class BaseViewModel : INotifyPropertyChanged
    {
        public BaseViewModel()
        {
        }

		#region Property changed

		public event PropertyChangedEventHandler PropertyChanged;

		internal void OnPropertyChanged([CallerMemberName] string name = null)
		{
			var changed = PropertyChanged;

			if (changed == null)
				return;

			changed.Invoke(this, new PropertyChangedEventArgs(name));
		}

		#endregion
	}
}

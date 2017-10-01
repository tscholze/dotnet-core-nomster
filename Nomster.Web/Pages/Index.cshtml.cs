using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using Nomster.Core.Model;
using Nomster.Core.ViewModel;

namespace Nomster.Web.Pages
{
    public class IndexModel : PageModel
    {
        #region Public members 

        /// <summary>
        /// Page's viewmodel
        /// </summary>
        public MainViewModel viewModel;

		#endregion

		#region Life cycle 

		public void OnGet()
        {
            viewModel = new MainViewModel();
        }

        #endregion
    }
}

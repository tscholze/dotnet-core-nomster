using System;
namespace Nomster.Core.Model
{
    /// <summary>
    /// Base model for all other models. It contains the omnipresent id and the
    /// MobileService Azure version.
    /// </summary>
    public class BaseModel
    {
        /// <summary>
        /// Unique ID.
        /// </summary>
        /// <value>The identifier.</value>
        public string Id { get; set; }

		#region Azure specific

		[Microsoft.WindowsAzure.MobileServices.Version]
		public string AzureVersion { get; set; }

		#endregion
	}
}

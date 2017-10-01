using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Microsoft.WindowsAzure.MobileServices;
using Microsoft.WindowsAzure.MobileServices.SQLiteStore;
using Microsoft.WindowsAzure.MobileServices.Sync;

using Nomster.Core.Model;
using Nomster.Core.Service;

using Xamarin.Forms;

[assembly: Dependency(typeof(AzureService))]
namespace Nomster.Core.Service
{
    public class AzureService
    {
		#region Public members

        /// <summary>
        /// Instanziated Azure Service client.
        /// </summary>
        /// <value>The client.</value>
		public MobileServiceClient Client { get; set; } = null;

        #endregion

        #region Private members 

        IMobileServiceSyncTable<Lunch> table;

        #endregion

        /// <summary>
        /// If the instance is not already initialized, it will create a new instance
        /// and sets up local databases and stores.
        /// </summary>
        /// <returns>The initialize.</returns>
        public async Task Initialize()
        {
            if (Client?.SyncContext?.IsInitialized ?? false)
                return;

            Client = new MobileServiceClient("");

            var path = "syncstore.db";
            path = Path.Combine(MobileServiceClient.DefaultDatabasePath, path);

            var store = new MobileServiceSQLiteStore(path);
            store.DefineTable<Lunch>();

            await Client.SyncContext.InitializeAsync(store, new MobileServiceSyncHandler());
            table = Client.GetSyncTable<Lunch>();
        }

        #region Data helper methods

        /// <summary>
        /// Gets all sycned lunches orderd by <see cref="Lunch.OfficeLeftDate"/>
        /// </summary>
        /// <returns>All, sorted lunches</returns>
        public async Task<IEnumerable<Lunch>> GetLunches()
        {
            await Initialize();
            await SyncLunches();

            return await table.OrderBy(s => s.OfficeLeftDate).ToEnumerableAsync();
        }

        #endregion

        #region Sync methods

        /// <summary>
        /// Syncs the local lunches table with the remote ones
        /// </summary>
        /// <returns>The lunches.</returns>
        public async Task SyncLunches()
        {
            try
            {
                await Client.SyncContext.PushAsync();
                await table.PullAsync("allLunches", table.CreateQuery());
            }
            catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine("An error occured: " + e.InnerException.ToString());
            }
        }

        #endregion
    }
}

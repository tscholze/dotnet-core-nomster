using System;
using System.Collections.ObjectModel;

using Nomster.Core.Model;

namespace Nomster.Core.Helper
{
    /// <summary>
    /// Helper class for mocking data sources.
    /// </summary>
    public static class MockHelper
    {
        /// <summary>
        /// Gets a list of mocked lunches
        /// </summary>
        /// <returns>List of mocked lunches</returns>
        public static ObservableCollection<Lunch> MockLunches()
        {
            var list = new ObservableCollection<Lunch>();
            list.Add(new Lunch() { Id = Guid.NewGuid().ToString(), Title = "City Döner", OfficeLeftDate = DateHelper.GetDateForHourAndMinute(11, 45), NumberOfAttendees = 1 });
			list.Add(new Lunch() { Id = Guid.NewGuid().ToString(), Title = "Subway Sandwich", OfficeLeftDate = DateHelper.GetDateForHourAndMinute(12, 15), NumberOfAttendees = 3 });
            list.Add(new Lunch() { Id = Guid.NewGuid().ToString(), Title = "\ud83c\uddf9\ud83c\udded  Ko Sa Mui", OfficeLeftDate = DateHelper.GetDateForHourAndMinute(13 ,0), NumberOfAttendees = 2 });

			return list;
        }
    }
}

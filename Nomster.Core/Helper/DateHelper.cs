using System;

namespace Nomster.Core.Helper
{
    /// <summary>
    /// Class for <see cref="DateTime"/> helper methods.
    /// </summary>
    public class DateHelper
    {
        /// <summary>
        /// Gets the Today date for a specific hour and minute value.
        /// </summary>
        /// <returns>Today value for hour and minute.</returns>
        /// <param name="hour">Hour.</param>
        /// <param name="minute">Minute.</param>
		public static DateTime GetDateForHourAndMinute(int hour, int minute)
		{
			return DateTime.Today.AddMinutes(hour * 60 + minute);
		}
    }
}

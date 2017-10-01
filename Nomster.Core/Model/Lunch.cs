using System;

namespace Nomster.Core.Model
{
    public class Lunch: BaseModel
    {
        /// <summary>
        /// Title of the lunch.
        /// </summary>
        /// <value>The title.</value>
        public string Title { get; set; }

        /// <summary>
        /// Datestamp when it is time to leave the office.
        /// </summary>
        /// <value>The office left date.</value>
        public DateTime OfficeLeftDate { get; set; }

        /// <summary>
        /// TimeSpan related to `OfficeLeftDate`s value.
        /// </summary>
        /// <value>The office left time.</value>
        public TimeSpan OfficeLeftTime
        {
            get
            {
                return OfficeLeftDate.TimeOfDay;
            }

            set
            {
                OfficeLeftDate = new DateTime(OfficeLeftDate.Year, OfficeLeftDate.Month, OfficeLeftDate.Day, value.Hours, value.Minutes, 0);
            }
        }

        /// <summary>
        /// Number of lunch's attendees.
        /// </summary>
        /// <value>The number of attendees.</value>
        public int NumberOfAttendees { get; set; }
    }
}

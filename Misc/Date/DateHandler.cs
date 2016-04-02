using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityParty.Misc.Date
{
    public class DateHandler
    {
        private DateTime date { get; set; }
        /// <summary>
        /// Property ensures that date is returned with a uniform property.
        /// </summary>
        public String dateString
        {
            get
            {
                return String.Format("{0}/{1}/{2}", date.Day, date.Month, date.Year);
            }
        }

        public DateHandler(DateTime t_date)
        {
            date = t_date;
        }

        public DateHandler()
        {
            date = DateTime.Now;
        }
    }
}

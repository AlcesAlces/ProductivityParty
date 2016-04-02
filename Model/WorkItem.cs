using ProductivityParty.Misc.Date;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityParty.Model
{
    public class WorkItem
    {
        /// <summary>
        /// Note: This ID needs to be here fore Dblite to work. Without it items can't be referenced.
        /// </summary>
        public int Id { get; set; }
        public String Task { get; set; }
        public String Notes { get; set; }
        private ObservableCollection<StatusBoxItem> mAvailableStatus = new ObservableCollection<StatusBoxItem>();
        public ObservableCollection<StatusBoxItem> AvailableStatus
        {
            get { return mAvailableStatus; }
            set { mAvailableStatus = value; }
        }
        public String date { get; set; }
        public int selectedItem { get; set; }

        public WorkItem()
        {

        }

        public WorkItem(String d)
        {
            AvailableStatus = new ObservableCollection<StatusBoxItem>()
            {
                new StatusBoxItem()
                {
                   display = "Complete"
                },
                new StatusBoxItem()
                {
                    display = "In Progress"
                }
            };

            selectedItem = 0;
            date = d;
        }

    }
}

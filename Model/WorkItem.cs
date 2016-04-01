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
        public String Task { get; set; }
        public String Notes { get; set; }
        private ObservableCollection<StatusBoxItem> mAvailableStatus = new ObservableCollection<StatusBoxItem>();
        public ObservableCollection<StatusBoxItem> AvailableStatus
        {
            get { return mAvailableStatus; }
            set { mAvailableStatus = value; }
        }

        public WorkItem()
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
        }

    }
}

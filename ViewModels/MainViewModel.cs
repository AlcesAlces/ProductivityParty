using ProductivityParty.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityParty.ViewModels
{
    class MainViewModel
    {
        private ObservableCollection<WorkItem> mWorkItem = new ObservableCollection<WorkItem>();
        public ObservableCollection<WorkItem> WorkItem
        {
            get { return mWorkItem; }
            set { mWorkItem = value; }
        }
    }
}

using LiteDB;
using ProductivityParty.Misc;
using ProductivityParty.Misc.Date;
using ProductivityParty.Misc.DBInteraction;
using ProductivityParty.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductivityParty.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region properties
        private Database db = new Database();
        private ObservableCollection<WorkItem> mWorkItem = new ObservableCollection<WorkItem>();
        public ObservableCollection<WorkItem> WorkItem
        {
            get { return mWorkItem; }
            set { mWorkItem = value; }
        }
        public String DateString
        {
            get
            {
                return Global.date;
            }
            set
            {
                Global.date = value;
                RaisePropertyChanged("DateString");
            }
        }

        DateHandler mDateHandler = new DateHandler();

        #endregion

        public class Customer
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string[] Phones { get; set; }
            public bool IsActive { get; set; }
        }

        public MainViewModel()
        {
            if (String.IsNullOrEmpty(Global.date))
            {
                Global.date = Global.DateToString(DateTime.Now);
                Database db = new Database();
                mWorkItem.Clear();
                foreach (WorkItem item in db.GetWorkItemsForDay(Global.date))
                {
                    mWorkItem.Add(item);
                }
            }
        }

        private void RaisePropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}

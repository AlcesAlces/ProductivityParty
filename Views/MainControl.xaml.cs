using ProductivityParty.Misc;
using ProductivityParty.Misc.DBInteraction;
using ProductivityParty.Model;
using ProductivityParty.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProductivityParty.Views
{
    /// <summary>
    /// Interaction logic for MainControl.xaml
    /// </summary>
    public partial class MainControl : UserControl
    {
        MainViewModel _viewModel = new MainViewModel();

        public MainControl()
        {
            InitializeComponent();
            DataContext = _viewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.WorkItem.Add(new Model.WorkItem(Global.date));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Database db = new Database();
            foreach (WorkItem item in _viewModel.WorkItem)
            {
                db.SaveWorkItem(item);
            }
            MessageBox.Show("I think I saved some stuff");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DateTime dt = DateTime.Parse(Global.date);
            dt = dt.AddDays(-1);
            Global.date = Global.DateToString(dt);
            _viewModel.DateString = Global.date;
            _viewModel.WorkItem.Clear();
            Database db = new Database();
            foreach (WorkItem item in db.GetWorkItemsForDay(Global.date))
            {
                _viewModel.WorkItem.Add(item);
            }
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            DateTime dt = DateTime.Parse(Global.date);
            dt = dt.AddDays(1);
            Global.date = Global.DateToString(dt);
            _viewModel.DateString = Global.date;
            _viewModel.WorkItem.Clear();
            Database db = new Database();
            foreach (WorkItem item in db.GetWorkItemsForDay(Global.date))
            {
                _viewModel.WorkItem.Add(item);
            }
        }
    }
}

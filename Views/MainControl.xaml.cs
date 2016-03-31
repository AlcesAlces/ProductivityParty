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
            _viewModel.WorkItem = new System.Collections.ObjectModel.ObservableCollection<Model.WorkItem>()
            {
                new Model.WorkItem()
                {
                    Test = "mamamia"
                },
                new Model.WorkItem()
                {
                    Test = "Wawawewa"
                }
            };
            DataContext = _viewModel;
        }
    }
}

using MahApps.Metro.Controls;
using ProductivityParty.ViewModels;
using ProductivityParty.Views;
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

namespace ProductivityParty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            ShowTitleBar = true;
            ShowIconOnTitleBar = true;
            this.Title = "Productivity Party";
            this.Content = new MainControl();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Content = new Settings();
        }
    }
}

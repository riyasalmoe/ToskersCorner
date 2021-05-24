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
using WPFINotifyPropertyChanged.ViewModels;

namespace WPFINotifyPropertyChanged
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly MainViewModel _main = new MainViewModel();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = _main;
            _main.SetBackground(Brushes.LightBlue);
        }

        private void RedButton_Click(object sender, RoutedEventArgs e)
        {
            _main.SetBackground(Brushes.Red);
        }

        private void BlueButton_Click(object sender, RoutedEventArgs e)
        {
            _main.SetBackground(Brushes.Blue);
        }

        private void GreenButton_Click(object sender, RoutedEventArgs e)
        {
            _main.SetBackground(Brushes.Green);
        }
    }
}

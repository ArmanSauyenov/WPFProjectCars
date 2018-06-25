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
using WPFProjectCars.Pages;
using WPFProjectCars.Windows;

namespace WPFProjectCars
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void showCars_Click(object sender, RoutedEventArgs e)
        {
            CentralListFrame.Source = new Uri("Pages/CarList.xaml", UriKind.RelativeOrAbsolute);
        }

        private void addCars_MouseDoubleClick(object sender, RoutedEventArgs e)
        {
            AddCars ac = new AddCars();
            ac.Show();
            
        }

        private void addCars_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {

        }
    }
}

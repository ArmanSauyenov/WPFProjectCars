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
using WPFProjectCars.LIB.Models;

namespace WPFProjectCars.Pages
{
    /// <summary>
    /// Interaction logic for CarList.xaml
    /// </summary>
    public partial class CarList : Page
    {
        public CarList()
        {
            InitializeComponent();
            Model1 model = new Model1();
            CarsList.ItemsSource = model.newEquipment.ToList();
        }
    }
}

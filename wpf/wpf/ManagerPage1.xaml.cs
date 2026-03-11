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

namespace wpf
{
    /// <summary>
    /// Interaction logic for ManagerPage1.xaml
    /// </summary>
    public partial class ManagerPage1 : Page
    {
        public ManagerPage1()
        {
            InitializeComponent();
        }

        private void customers_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new NumberCustomer());
        }

        private void orders_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ContentButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ManageButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void addCatagoria_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new addCategory());
        }

        private void addProduct_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new addProduct());
        }
    }
}

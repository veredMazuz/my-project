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
    /// Interaction logic for CustomerPage1.xaml
    /// </summary>
    public partial class CustomerPage1 : Page
    {
        public CustomerPage1()
        {
            InitializeComponent();
            LabelName.Content += Global.customerDTO.Name;
            //Global.service
            //Global.orderDTO.Customer.CustomerID=Global.customerDTO.CustomerID;
            //Global.service.AddOrder(Global.orderDTO);
        }

        private void myOrder_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OrderView());
        }

        private void menu_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProductView());
        }
         
      
    }
}

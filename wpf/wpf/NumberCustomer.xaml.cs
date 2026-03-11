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
    /// Interaction logic for NumberCustomer.xaml
    /// </summary>
    public partial class NumberCustomer : Page
    {
        public NumberCustomer()
        {
            InitializeComponent();
            //text1.Text = Service1.num().ToString();
            customers.ItemsSource = Global.service.GetCustomers();
        }

        public object Service1 { get; }

        private void count_Click(object sender, RoutedEventArgs e)
        {
            text1.Text = Global.service.customerCount().ToString();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new addCustomer());
        }
    }
}

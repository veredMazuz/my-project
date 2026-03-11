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
    /// Interaction logic for MyBasket.xaml
    /// </summary>
    public partial class MyBasket : Page
    {
        public MyBasket()
        {
            InitializeComponent();
        }

        private void BackToMenu_Click(object sender, RoutedEventArgs e)
        {
            if (this.NavigationService.CanGoBack)
                this.NavigationService.GoBack();
        }

        private void Checkout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("הזמנתך התקבלה!");
            this.NavigationService.Navigate(new Login());
        }
    }
}

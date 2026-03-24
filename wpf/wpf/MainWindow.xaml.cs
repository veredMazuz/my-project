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
using System.Windows.Shapes;
using wpf.ServiceReference1;
using wpf;

namespace wpf
{
    /// <summary>
    /// Interaction logic for MainWindowF.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Service1Client service1 = new Service1Client();

        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new Login());
        }

        private void btnGlobalBack_Click(object sender, RoutedEventArgs e)
        {
            // אם ה-Frame יכול לחזור אחורה - הוא יחזור
            if (MainFrame.CanGoBack)
            {
                MainFrame.GoBack();
            }
        }
    }
}

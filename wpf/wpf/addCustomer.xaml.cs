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
    /// Interaction logic for addCustomer.xaml
    /// </summary>
    public partial class addCustomer : Page
    {
        public addCustomer()
        {
            InitializeComponent();
        }

        private TextBox GetTxtCustomerID()
        {
            return txtCustomerID;
        }

        

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            ServiceReference1.CustomerDTO c = new ServiceReference1.CustomerDTO();
            c.CustomerID = int.Parse(txtCustomerID.Text);
            c.Name = txtCustomerName.Text;
            c.Phone = txtCustomerPhone.Text;
            c.Address = txtCustomerAdrres.Text;

            if (Global.service.AddCustomer(c))
            {
                MessageBox.Show("הלקוח נוסף בהצלחה");
            }
            else
                MessageBox.Show("שגיאה בהוספת לקוח");
        }
    }
}

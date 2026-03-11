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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            
            InitializeComponent();
            SetRandomBackground();
        }


        private void SetRandomBackground()
        {
            // רשימת שמות התמונות שיש לך בתיקייה
            string[] images = { "bread.jpg", "/Images/fish.jpg" }; 

            // בחירת מספר אקראי
            Random rand = new Random();
            int index = rand.Next(images.Length);

            // יצירת הנתיב המלא
            string imagePath = "/Images/" + images[index];

            // הגדרת התמונה לאלמנט ב-XAML
            BackgroundImage.Source = new BitmapImage(new Uri(imagePath, UriKind.Relative));


        }
       
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new addCustomer());
        }

        private void btnShowHide_Click(object sender, RoutedEventArgs e)
        {
           
            {
                if (txtCustomerPhone.Visibility == Visibility.Visible)
                {
                    txtVisiblePhone.Text = txtCustomerPhone.Password;
                    txtCustomerPhone.Visibility = Visibility.Collapsed;
                    txtVisiblePhone.Visibility = Visibility.Visible;
                    btnShowHide.Content = "🙈";
                }
                else
                {
                    txtCustomerPhone.Password = txtVisiblePhone.Text;
                    txtVisiblePhone.Visibility = Visibility.Collapsed;
                    txtCustomerPhone.Visibility = Visibility.Visible;
                    btnShowHide.Content = "👁";
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string phone = txtCustomerPhone.Password;

            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("יש למלא מספר טלפון (סיסמה)");
                return;
            }

            // בדיקה אם זה המנהל
            if (phone == "0533149052")
            {
                Global.customerDTO = Global.service.GetCustomerByPhone(phone);
                NavigationService.Navigate(new ManagerPage1());
            }
            else
            {
                // ניסיון שליפת לקוח לפי מספר טלפון
                Global.customerDTO = Global.service.GetCustomerByPhone(phone);

                if (Global.customerDTO != null)
                {
                    NavigationService.Navigate(new CustomerPage1());
                }
                else
                {
                    MessageBox.Show("שם משתמש או סיסמה שגויים");
                }
            }
        }
    }
}

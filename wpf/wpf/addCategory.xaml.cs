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
using wpf.ServiceReference1;

namespace wpf
{
    /// <summary>
    /// Interaction logic for addCategory.xaml
    /// </summary>
    public partial class addCategory : Page
    {
        //private object Service1;

        public addCategory()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CategoryDTO c = new CategoryDTO();
            c.CategoryName = txtNameCategory.Text;
            if (Global.service.AddCategory(c))
            
                MessageBox.Show("קטגוריה נוספה בהצלחה");
                else

                    MessageBox.Show("שגיאה בהוספת הקטגוריה");
            
        }


        }

        
}

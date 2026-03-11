using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using wpf.ServiceReference1;

namespace wpf
{
    /// <summary>
    /// Interaction logic for addProduct.xaml
    /// </summary>
    public partial class addProduct : Page
    {
        public addProduct()
        {
            InitializeComponent();
            LoadCategory();
        }

        private void LoadCategory()
        {
            List<CategoryDTO>  Category = Global.service.GetCategories().ToList();
            cmbCategory.ItemsSource = Category;

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ProductDTO product = new ProductDTO();
            product.ProductName = txtNameProduct.Text;
            product.Description = txtDescription.Text;
            product.Price = int.Parse(txtPrice.Text);
            //product.Category = (catgoroyDTO)cmbCategory.SelectedItem;

            bool result = Global.service.AddProduct(product);

            if (result)
                MessageBox.Show("המוצר נוסף בהצלחה");
            else
                MessageBox.Show("שגיאה בהוספה");

        }
    }
}

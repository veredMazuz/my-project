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
    /// Interaction logic for ProductView.xaml
    /// </summary>
    public partial class ProductView : Page
    {
        private List<ProductDTO> products;
        private List<CategoryDTO> categories;

        public ProductView()
        {
            InitializeComponent();
            LoudProducts();
            LoudCategoria();
        }

        private void LoudProducts()
        {
            products = Global.service.GetProducts().ToList();
            foreach(var product in products)
            {
                uGridProducts.Children.Add(new ProductCard(product));
            }

        }

        private void LoudCategoria()
        {
            categories = Global.service.GetCategories().ToList();
            foreach (var category in categories)
            {
              spCategoria.Children.Add(new CategoriaCard(category));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MyBasket());
        }
    }
}

           



       

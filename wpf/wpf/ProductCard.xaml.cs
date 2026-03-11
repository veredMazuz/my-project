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
    /// Interaction logic for ProductCard.xaml
    /// </summary>
    public partial class ProductCard : UserControl
    {
        ProductDTO Product;
        public ProductCard(ProductDTO p)
        {
            InitializeComponent();
            this.Product = p;
            this.DataContext = Product;

        }

        private void addProduct_Click(object sender, RoutedEventArgs e)
        {
            // 1. בדיקה האם קיימת הזמנה פתוחה
            int orderId = Global.service.orderOpen(Global.ShabbatParsha, Global.customerDTO.CustomerID);

            // אובייקט של פרטי ההזמנה שנשלח בסוף
            OrderDetailDTO orderDetail = new OrderDetailDTO();
            orderDetail.Product = this.Product; // המוצר הנוכחי
            orderDetail.Quantity = 1; // או כמות מה-TextBox שלך

            if (orderId == -1)
            {
                // --- מקרה א': אין הזמנה פתוחה - יוצרים אחת חדשה ---
                OrderDTO newOrder = new OrderDTO();
                newOrder.ShabbatParsha = Global.ShabbatParsha;
                newOrder.OrderDate = DateTime.Now;
                newOrder.Customer = Global.customerDTO;
                Global.service.AddOrder(newOrder);

                // שליפת ה-ID שנוצר עכשיו מהשרת
                orderId = Global.service.GetIdOrder();
            }

            // עדכון ה-ID בתוך פרטי ההזמנה
            orderDetail.Order = new OrderDTO { OrderID = orderId };

            // הוספת המוצר לסל (לשורות ההזמנה)
            bool isAdded = Global.service.AddOrderDetail(orderDetail);

            if (isAdded)
            {
                MessageBox.Show("המוצר נוסף לסל בהצלחה!");
            }
        }


       
    }
}

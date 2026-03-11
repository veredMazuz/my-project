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
    /// Interaction logic for CategoriaCard.xaml
    /// </summary>
    public partial class CategoriaCard : UserControl
    {
        CategoryDTO c;
        public CategoriaCard(CategoryDTO c)
        {
            InitializeComponent();
            this.c = c;
            this.DataContext = c;
        }
    }
}

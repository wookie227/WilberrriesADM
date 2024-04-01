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
using WilberrriesADM.Models;
using WilberrriesADM.ViewModel;

namespace WilberrriesADM.View
{
    /// <summary>
    /// Логика взаимодействия для EditQuantityProduct.xaml
    /// </summary>
    public partial class EditQuantityProduct : Window
    {
        public EditQuantityProduct(Product product)
        {
            InitializeComponent();
            DataContext = new ProductsViewModel();
        }
    }
}

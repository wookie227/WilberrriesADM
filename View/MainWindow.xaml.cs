using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WilberrriesADM.ViewModel;

namespace WilberrriesADM.View
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SellersViewModel sellersViewModel = new SellersViewModel();
            SellersTab.DataContext = sellersViewModel;

            ProductsViewModel productsViewModel = new ProductsViewModel();
            ProductsTab.DataContext = productsViewModel;

            ClientsViewModel clientsViewModel = new ClientsViewModel();
            ClientTab.DataContext = clientsViewModel;

            EmployeesViewModel employeesViewModel = new EmployeesViewModel();
            EmployeesTab.DataContext = employeesViewModel;

            PVZViewModel pVZViewModel = new PVZViewModel();
            PVZTab.DataContext = pVZViewModel;

            OrdersViewModel ordersViewModel = new OrdersViewModel();
            OrderTab.DataContext = ordersViewModel;

            IssuanceViewModel issuanceViewModel = new IssuanceViewModel();
            IssuanceTab.DataContext = issuanceViewModel;
        }
    }
}
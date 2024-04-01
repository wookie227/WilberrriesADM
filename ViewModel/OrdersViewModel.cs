using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using WilberrriesADM.Data;
using WilberrriesADM.Models;

namespace WilberrriesADM.ViewModel
{
    public class OrdersViewModel : ViewModelBase
    {
        private ObservableCollection<Order> _allOrders;

        public ObservableCollection<Order> AllOrders
        {
            get { return _allOrders; }
            set
            {
                _allOrders = value;
                OnPropertyChanged(nameof(AllOrders));
            }
        }

        public OrdersViewModel()
        {
            using var context = new DataBase();
            AllOrders = new ObservableCollection<Order>(context.Orders.ToList());
        }
    }
}

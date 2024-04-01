using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WilberrriesADM.Data;
using WilberrriesADM.Models;

namespace WilberrriesADM.ViewModel
{
    public class IssuanceViewModel : ViewModelBase
    {
        private ObservableCollection<OrderDelivery> _allIssuance;

        public ObservableCollection<OrderDelivery> AllIssuance
        {
            get { return _allIssuance; }
            set
            {
                _allIssuance = value;
                OnPropertyChanged(nameof(AllIssuance));
            }
        }

        public IssuanceViewModel()
        {
            using var context = new DataBase();
            AllIssuance = new ObservableCollection<OrderDelivery>(context.OrdersDeliveries.ToList());
        }
    }
}

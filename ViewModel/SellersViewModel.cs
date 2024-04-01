using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WilberrriesADM.Data;
using WilberrriesADM.Models;

namespace WilberrriesADM.ViewModel
{
    public class SellersViewModel : ViewModelBase
    {
        private ObservableCollection<Seller> _allSellers;

        public ObservableCollection<Seller> AllSellers
        {
            get { return _allSellers; }
            set
            {
                _allSellers = value;
                OnPropertyChanged(nameof(AllSellers));
            }
        }

        public SellersViewModel()
        {
            using var context = new DataBase();
            AllSellers = new ObservableCollection<Seller>(context.Sellers.ToList());
        }
    }
}

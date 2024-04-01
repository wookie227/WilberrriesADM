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
    public class ClientsViewModel : ViewModelBase
    {

        private ObservableCollection<Customer> _allClients;

        public ObservableCollection<Customer> AllClients
        {
            get { return _allClients; }
            set
            {
                _allClients = value;
                OnPropertyChanged(nameof(AllClients));
            }
        }

        public ClientsViewModel()
        {
            using var context = new DataBase();
            AllClients = new ObservableCollection<Customer>(context.Customers.ToList());
        }
    }
}

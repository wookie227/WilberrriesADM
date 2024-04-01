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
    public class PVZViewModel : ViewModelBase
    {
        private ObservableCollection<PickupPoint> _allPVZ;

        public ObservableCollection<PickupPoint> AllPVZ
        {
            get { return _allPVZ; }
            set
            {
                _allPVZ = value;
                OnPropertyChanged(nameof(AllPVZ));
            }
        }

        public PVZViewModel()
        {
            using var context = new DataBase();
            AllPVZ = new ObservableCollection<PickupPoint>(context.PickupPoints.ToList());
        }
    }
}

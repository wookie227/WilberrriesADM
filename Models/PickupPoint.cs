using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WilberrriesADM.Models
{
    public class PickupPoint
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string WorkingHours { get; set; }
        public int Rating { get; set; }

        public virtual ICollection<OrderDelivery> OrderDeliveries { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WilberrriesADM.Models
{
    public class OrderDelivery
    {
        [Key]
        public int ID { get; set; }
        public DateTime DeliveryDate { get; set; }

        [ForeignKey("PickupPoint")]
        public int PickupPoint_ID { get; set; }
        public virtual PickupPoint PickupPoint { get; set; }

        [ForeignKey("Order")]
        public int Order_ID { get; set; }
        public virtual Order Order { get; set; }
    }
}

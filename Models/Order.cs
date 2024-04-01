using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WilberrriesADM.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; }

        [ForeignKey("Customer")]
        public int Customer_ID { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual ICollection<ProductInOrder> Products { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WilberrriesADM.Models
{
    public class ProductInBasket
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Basket")]
        public int Basket_ID { get; set; }
        public virtual Basket Basket { get; set; }

        [ForeignKey("Product")]
        public int Product_ID { get; set; }
        public virtual Product Product { get; set; }

        public int Quantity { get; set; }
    }
}

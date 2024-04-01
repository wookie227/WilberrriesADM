using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WilberrriesADM.Models
{
    public class EmployeeInPickupPoint
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Employee")]
        public int Employee_ID { get; set; }
        public virtual Employee Employee { get; set; }

        [ForeignKey("PickupPoint")]
        public int PickupPoint_ID { get; set; }
        public virtual PickupPoint PickupPoint { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHDai19DemoEF.Model
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string UserName { get; set; }
        public DateTime OrderDate { get; set; }
        [StringLength(50)]
        public string ShipName { get; set; }
        [StringLength(250)]
        public string ShipAddress { get; set; }

        public virtual User User { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}

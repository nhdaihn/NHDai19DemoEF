using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NHDai19DemoEF.Model
{
    public class OrderDetail
    {
        [Key]
        [Column(Order = 1)]
        public int OrderId { get; set; }
        [Key]
        [Column(Order = 2)]
        public int BookId { get; set; }
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public decimal UnitPrice { get; set; }
        public float Discount { get; set; }
        public int Quantity { get; set; }

        public virtual Order Order { set; get; }

        public virtual Book Book { set; get; }
    }
}
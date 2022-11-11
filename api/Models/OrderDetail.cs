
using System.ComponentModel.DataAnnotations;

namespace api
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        public int OrderMasterId { get; set; }
        public OrderMaster OrderMaster { get; set; } = null!;
        public int ProductItemId { get; set; }
        public ProductItem ProductItem { get; set; } = null!;
        public decimal ProductItemPrice { get; set; }
        public int Quantity { get; set; }

    }
}
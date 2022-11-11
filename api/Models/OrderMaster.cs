using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api
{
    public class OrderMaster
    {
        [Key]
        public int OrderMasterId { get; set; }

        [Column(TypeName = "nvarchar(75)")]

        public string OrderNumber { get; set; } = null!;

        public int CustomerId { get; set; }

        public Customer Customer { get; set; } = null!;

        [Column(TypeName = "nvarchar(75)")]

        public string PMethod { get; set; } = null!;

        public decimal GTotal { get; set; }

        public List<OrderDetail> OrderDetails { get; set; } = null!;

        [NotMapped]
        public string DeletedOrderItemIds { get; set; } = null!;
    }
}
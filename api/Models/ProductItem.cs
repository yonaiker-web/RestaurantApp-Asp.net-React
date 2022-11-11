using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api;
public class ProductItem
{

    [Key]
    public int ProductItemId { get; set; }

    [Column(TypeName = "nvarchar(100)")]
    public string ProductItemName { get; set; } = null!;

    [Column(TypeName = "decimal(10, 2)")]
    public decimal Price { get; set; }
}
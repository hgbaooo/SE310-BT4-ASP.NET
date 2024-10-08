using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLySanPham.Models;

[Table("Catalog")]
public class Catalog
{
    [Key] public int Id { get; set; }

    [StringLength(50)] public string? CatalogCode { get; set; }

    [StringLength(250)] public string? CatalogName { get; set; }

    [InverseProperty("Catalog")] public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLySanPham.Models;

[Table("Product")]
public sealed class Product
{
    [Key] public int Id { get; set; }

    public int? CatalogId { get; set; }

    [StringLength(50)] public string? ProductCode { get; set; }

    [StringLength(250)] public string? ProductName { get; set; }

    public string? Picture { get; set; }

    public double? UnitPrice { get; set; }

    [ForeignKey("CatalogId")]
    [InverseProperty("Products")]
    public Catalog? Catalog { get; set; }
}
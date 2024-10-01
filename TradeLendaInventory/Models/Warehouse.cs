using System.ComponentModel.DataAnnotations;

namespace TradeLendaInventory.Models
{
    public class Warehouse
    {
        [Key]
        public string WarehouseId { get; set; }
        [Required]
        public string? WarehouseName { get; set; } = string.Empty;

        [Required]
        public string? ContactPhone { get; set; } = string.Empty;

        [Required]
        public string? ContactPerson { get; set; } = string.Empty;

        public Supplier? supplier { get; set; } = new Supplier();
        public Stock? Stock { get; set; } = new Stock();

        public List<Store>? Stores { get; set; } = new List<Store>();

        public string? Address1 { get; set; } = string.Empty;

        public string? Address2 { get; set; } = string.Empty;

        public string? State { get; set; } = string.Empty;
        public string? City { get; set; } = string.Empty;

        public string? ZipCode { get; set; } = string.Empty;
        public string? Country { get; set; } = string.Empty;

        public int? Quantity { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public bool? Status { get; set; } = false;

    }
}

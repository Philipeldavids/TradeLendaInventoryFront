using System.ComponentModel.DataAnnotations;

namespace TradeLendaInventory.Models
{
    public class StoreModel
    {
        [Required]
        public string StoreName { get; set; } = string.Empty;

        public string ContactPerson { get; set; } = string.Empty;

        [Required]
        public int WarehouseID { get; set; }
        public string Email { get; set; }

        public string PhoneNumber { get; set; }
        public bool Status { get; set; }
    }
}

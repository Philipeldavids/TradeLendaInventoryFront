using System.ComponentModel.DataAnnotations;

namespace TradeLendaInventory.Models
{
    public class WarehouseModel
    {
        public string WarehouseName { get; set; } = string.Empty;
           
        public string ContactPerson { get; set; } = string.Empty;
        
        public string PhoneNumber { get; set; } = string.Empty;

        public string WorkPhone { get; set; } = string.Empty;
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public string Address1 { get; set; } = string.Empty;

        public string Address2 { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;

        public string State { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;

        public string ZipCode { get; set; } = string.Empty;
    }
}

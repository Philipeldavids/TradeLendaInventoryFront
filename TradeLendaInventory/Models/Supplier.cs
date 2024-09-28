using System.ComponentModel.DataAnnotations;

namespace TradeLendaInventory.Models
{
    public class Supplier
    {
       
        [Required]
        public string Name { get; set; }
        [Required]
        public int Code { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? Description { get; set; }
    }
}

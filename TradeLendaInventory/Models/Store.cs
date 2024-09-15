using System.ComponentModel.DataAnnotations;

namespace TradeLendaInventory.Models
{
    public class Store
    {
        [Required]
        public string StoreName { get; set; } = string.Empty;

        [Required]
        public string UserName { get; set; }= string.Empty;

        [Required]
        public string PhoneNumber { get; set; }= string.Empty;
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        public bool Status { get; set; } 
    }
}

using System.ComponentModel.DataAnnotations;

namespace TradeLendaInventory.Models
{
    public class LoginModel
    {
        [Required, MaxLength(100)]
        public string UserName { get; set; } = string.Empty;
        [Required, MaxLength(255)]
        public string Password { get; set; } = string.Empty;
    }
}

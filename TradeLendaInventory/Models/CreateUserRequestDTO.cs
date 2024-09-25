using System.ComponentModel.DataAnnotations;

namespace TradeLendaInventory.Models
{
    public class CreateUserRequestDTO
    {

        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required, EmailAddress, MaxLength(100)]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }

        [Required, MinLength(6), MaxLength(100)]
        public string Password { get; set; }
        [Required, MinLength(6), MaxLength(100)]
        public string ConfirmPassword { get; set; }
        [Required]
        public bool? IsAgreement { get; set; }
        public Roles? Roles { get; set; }
        public string? Description { get; set; }


    }
}


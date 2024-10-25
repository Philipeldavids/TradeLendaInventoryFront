using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace TradeLendaInventory.Models
{
    public class RegisterModel
    {
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required, EmailAddress, MaxLength(100)]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
        [Required, MinLength(6), MaxLength(100)]
        public string Password { get; set; }
        [Required, MinLength(6),MaxLength(100)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        [Required]
        public bool IsAgreement { get; set; }
        [Required]

        public Roles Role { get; set; } 
      
    
    }
    

}

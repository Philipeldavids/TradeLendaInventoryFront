using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics.CodeAnalysis;

namespace TradeLendaInventory.Models
{
    public class User : IdentityUser 
    {
        [Key]
        public string UserId { get; set; } = Guid.NewGuid().ToString();

        [Required, EmailAddress, MaxLength(100)]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [AllowNull]
        public Roles Role { get; set; }
        public UserProfile UserProfil { get; set; } = new UserProfile();

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? LastLogin { get; set; }

        public bool IsActive { get; set; } = true;

        public string RefreshToken { get; set; }

        public DateTime RefreshTokenExpiryTime { get; set; }
    }
    public class UserProfile
    {
        [Key]
        public string UserProfileId { get; set; } = Guid.NewGuid().ToString();

        public string UserId { get; set; }
        [Required, MaxLength(100)]
        public string FirstName { get; set; }
        [Required, MaxLength(100)]
        public string LastName { get; set; }

        [Required]
        public string PhoneNumber { get; set; }
        
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string UserImage { get; set; } = string.Empty;

    }
    public enum Roles
    {
        Admin = 0,
        Customer = 1,
        ShopOwner = 2,
        SuperAdmin = 3
    }
}

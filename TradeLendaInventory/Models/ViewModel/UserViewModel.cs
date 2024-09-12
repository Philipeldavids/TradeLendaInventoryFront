using System.ComponentModel.DataAnnotations;
using System.Data;

namespace TradeLendaInventory.Models.ViewModel
{
    public class UserViewModel
    {

        public string Username { get; set; }
              
        public string Role { get; set; }

       // public string ImageUrl { get; set; }

        //public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        //public DateTime? LastLogin { get; set; }

        public bool IsActive { get; set; } = true;

       
    }
   
}

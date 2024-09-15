using System.ComponentModel.DataAnnotations;
using System.Data;

namespace TradeLendaInventory.Models.ViewModel
{
    public class UserViewModel
    {
        public string Username { get; set; }
              
        public string Role { get; set; }   

        public bool IsActive { get; set; }
       
    }
   
}

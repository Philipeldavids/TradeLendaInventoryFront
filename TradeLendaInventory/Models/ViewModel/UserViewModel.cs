using System.ComponentModel.DataAnnotations;
using System.Data;

namespace TradeLendaInventory.Models.ViewModel
{
    public class UserViewModel
    {

        public List<User> users { get; set; } = new List<User>();

        public  CreateUserRequestDTO userrequest { get; set; } = new CreateUserRequestDTO();
       
    }
   
}

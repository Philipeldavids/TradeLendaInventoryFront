using System.ComponentModel.DataAnnotations;

namespace TradeLendaInventory.Models
{
    public class CategoryModel
    {
        [Required, MaxLength(50)]
        public string CategoryName { get; set; } = string.Empty;
        public string CategorySLug { get; set; }= string.Empty;

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        public bool Status { get; set; }
    }
}

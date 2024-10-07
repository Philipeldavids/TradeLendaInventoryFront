using System.ComponentModel.DataAnnotations;

namespace TradeLendaInventory.Models
{
    public class BrandDTO
    {
        [Required, MaxLength(50)]
        public string BrandName { get; set; }

        public string? Logo { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public bool Status { get; set; }
    }
}

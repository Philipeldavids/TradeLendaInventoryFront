using System.ComponentModel;

namespace TradeLendaInventory.Models.ViewModel
{
    public class ProductViewModel
    {
        public IEnumerable<Product> Products { get; set; } = Enumerable.Empty<Product>();

    }
}

using System.ComponentModel;

namespace TradeLendaInventory.Models.ViewModel
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int SKU { get; set; }       
        public decimal Price {  get; set; }
        public string Unit {  get; set; }
        public int Quantity { get; set; }
        public string CreatedBy { get; set; }

    }
}

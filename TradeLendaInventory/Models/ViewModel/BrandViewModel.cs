namespace TradeLendaInventory.Models.ViewModel
{
    public class BrandViewModel
    {
        public List<Brand> brands { get; set; } = new List<Brand>();

        public BrandDTO brand { get; set; } = new BrandDTO();

    }
}

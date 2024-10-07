namespace TradeLendaInventory.Models.ViewModel
{
    public class BarcodeViewModel
    {
        public ProductViewModel productView { get; set; } = new ProductViewModel();
        public ProductModel product { get; set; } = new ProductModel();
        public bool ShowProductName { get; set; }
        public bool ShowStoreName { get; set; }
        public bool ShowPrice { get; set; }
    }
}

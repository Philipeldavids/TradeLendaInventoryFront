namespace TradeLendaInventory.Models.ViewModel
{
    public class StockViewModel
    {
        public List<Stock> stocks { get; set; } = new List<Stock>();
        public Stock stock = new Stock();
    }
}

namespace TradeLendaInventory.Models.ViewModel
{
    public class StockTransferViewModel
    {
        public List<StockTransfer> StockTransferList { get; set; } = new List<StockTransfer>();

        public StockTransfer StockTransfer { get; set; } = new StockTransfer();
    }
}

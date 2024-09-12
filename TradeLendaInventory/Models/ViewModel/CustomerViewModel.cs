namespace TradeLendaInventory.Models.ViewModel
{
    public class CustomerViewModel
    {
        public List<Customer> Customers { get; set; } = new List<Customer>();

        public CustomerModel model { get; set; } = new CustomerModel();
    }
}

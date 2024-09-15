namespace TradeLendaInventory.Models.ViewModel
{
    public class CustomerViewModel
    {
        public List<Customer> Customers { get; set; } = new List<Customer>();

        public Customer customer { get; set; } = new Customer();
    }
}

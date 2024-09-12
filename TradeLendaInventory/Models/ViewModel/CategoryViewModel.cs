namespace TradeLendaInventory.Models.ViewModel
{
    public class CategoryViewModel
    {
        public List<Category> Categories {  get; set; } = new List<Category>();

        public Category category { get; set; } = new Category();
    }
}

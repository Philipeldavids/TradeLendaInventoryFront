namespace TradeLendaInventory.Models
{
    public class TokenResponse
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }

        public User User { get; set; } = new User();
    }
}

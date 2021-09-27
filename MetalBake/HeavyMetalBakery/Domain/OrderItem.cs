namespace HeavyMetalBakery.Domain
{
    public class OrderItem
    {
        public OrderItem(string itemId)
        {
            ItemId = itemId;
            Amount = 1;
        }

        public int Amount { get; set; }
        public decimal BasePrice { get; set; }
        public string ItemId { get; }
        public decimal TotalPrice { get { return Amount * BasePrice; } }

        public void IncreaseAmount()
        {
            Amount++;
        }
    }
}
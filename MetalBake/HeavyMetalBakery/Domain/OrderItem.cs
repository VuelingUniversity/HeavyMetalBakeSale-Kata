namespace HeavyMetalBakery.Domain
{
    class OrderItem
    {
        public int Amount { get; private set; }
        public decimal BasePrice { get; set; }
        public string ItemId { get; }
        public decimal TotalPrice { get { return Amount * BasePrice; } }
        public void IncreaseAmount()
        {
            Amount++;
        }

    }
}

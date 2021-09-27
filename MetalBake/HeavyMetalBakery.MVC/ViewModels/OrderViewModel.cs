using HeavyMetalBakery.Domain;

namespace HeavyMetalBakery.MVC.ViewModels
{
    public class OrderViewModel
    {
        public Order Order { get; set; }
        public OrderItem Item { get; set; }
    }
}
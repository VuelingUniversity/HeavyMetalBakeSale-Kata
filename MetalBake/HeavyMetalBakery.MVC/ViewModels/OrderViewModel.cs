using HeavyMetalBakery.Domain;

namespace HeavyMetalBakery.MVC.ViewModels
{
    public class OrderViewModel
    {
        public Order Order { get; internal set; }
        public OrderItem Item { get; set; }
    }
}
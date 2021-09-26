using MetalBake.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBake.core.Services
{
    public interface IOrderService
    {
        Order CreateOrder(List<Tuple<string, int>> itemsQuantity);

        List<string> ProcessOrder(Order order);
    }
}
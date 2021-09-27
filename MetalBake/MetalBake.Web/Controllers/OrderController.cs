using MetalBake.ApplicationServices;
using MetalBake.core.Models;
using MetalBake.core.Services;
using MetalBake.infra;
using MetalBake.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetalBake.Web.Controllers
{
    public class OrderController : Controller
    {
        private IItemService _itemService;
        private IOrderService _orderService;

        public OrderController()
        {
            _itemService = new ItemService();
            _orderService = new OrderService();
        }

        // GET: Order
        public ActionResult Index()
        {
            ItemsList itemsList = new ItemsList();
            itemsList.ListOfItems = _itemService.GetAllItems();
            return View(itemsList);
        }

        public ActionResult AddToCart(OrderForm orderForm)
        {
            List<Tuple<string, int>> order;
            if (HttpContext.Session["items"] == null)
            {
                order = new List<Tuple<string, int>>();
            }
            else
            {
                order = HttpContext.Session["items"] as List<Tuple<string, int>>;
            }
            order.Add(new Tuple<string, int>(orderForm.ItemId, orderForm.Quantity));

            HttpContext.Session["items"] = order;
            return View();
        }

        public ActionResult MakeAnOrder(List<Tuple<string, int>> items)
        {
            List<Tuple<string, int>> orderForms = HttpContext.Session["items"] as List<Tuple<string, int>>;
            Order order = _orderService.CreateOrder(orderForms);
            List<string> errors = _orderService.ProcessOrder(order);

            HttpContext.Session["items"] = null;

            OrderView view = new OrderView { Summary = order.GetSummary(), Errors = errors, TotalPrice = order.CalculateOrderPrice() };
            return View(view);
        }

        public ActionResult GiveChange(ChangeForm changeForm)
        {
            decimal change = changeForm.Amount - changeForm.Total;
            ChangeView view = new ChangeView { Change = change };
            return View(view);
        }
    }
}
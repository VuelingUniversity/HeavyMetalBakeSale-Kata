using System.Web.Mvc;

namespace MetalBandBakery.MVC.Controllers
{
    public class StockController : Controller
    {
        // GET: Stock

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetStock(string[] itemId)
        {

            return View();
        }
    }
}
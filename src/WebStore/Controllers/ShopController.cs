using Microsoft.AspNetCore.Mvc;

namespace WebStore.Controllers
{
    [Route("")]
    public class ShopController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ProductController : Controller
    {
        // GET: ProductController
        public ActionResult Index()
        {
            return View();
        }

    }
}

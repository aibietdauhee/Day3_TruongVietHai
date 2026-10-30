using Microsoft.AspNetCore.Mvc;

namespace Day3_TruongVietHai.data
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}

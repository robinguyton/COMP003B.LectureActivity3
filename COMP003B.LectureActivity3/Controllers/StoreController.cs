using Microsoft.AspNetCore.Mvc;

namespace COMP003B.LectureActivity3.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

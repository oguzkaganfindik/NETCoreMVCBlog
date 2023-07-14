using Microsoft.AspNetCore.Mvc;

namespace NETCoreMVCBlog.Controllers
{
    public class YorumController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

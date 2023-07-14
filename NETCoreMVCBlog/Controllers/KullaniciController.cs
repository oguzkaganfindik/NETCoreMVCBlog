using Microsoft.AspNetCore.Mvc;
using NETCoreMVCBlog.Models;

namespace NETCoreMVCBlog.Controllers
{
    public class KullaniciController : Controller
    {
        public IActionResult Index()
        {
            Kullanici k1 = new Kullanici() { KullaniciAdi = "OguzkaganFindik", Email = "oguzkagan@abcxyz.com" };
            return View(k1);
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace BaiTapVeNha02.Controllers
{
    public class Tuan02Controller : Controller
    {
        public IActionResult Index()
        {
            ViewBag.HoTen = "Lam Gia Kiet";
            ViewBag.MSSV = "1822041104";
            ViewBag.Nam = "Nam 2024";
            return View();
        }
    }
}

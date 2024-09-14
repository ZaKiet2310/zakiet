using BaiTapKiemTra01.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiTapKiemTra01.Controllers
{
    public class BaiTap2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();  
        }
        public IActionResult BaiTap2(SanPhamViewModel SanPham)
        
            {
                var sanpham = new SanPhamViewModel()
                {
                    TenSanPham = "Ban phim wooting 60he",
                    GiaBan = 3000000,
                    AnhMoTa = "/images/kb.jpg"
                };
                return View(sanpham);
            
        }
    }
}

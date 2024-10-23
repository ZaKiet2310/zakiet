using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project1.Data;
using System.Security.Claims;

namespace Project1.Controllers
{
    [Area("Customer")]
    public class GioHangController : Controller
    {
        private readonly ApplicationDbContext _db;

        public GioHangController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            //Lay thong tin dang nhap
            var identity = (ClaimsIdentity)User.Identity;
            var claim = identity.FindFirst(ClaimTypes.NameIdentifier);

            //Lay danh sach san pham trong gio hang cua user
            IEnumerable<GioHang> dsGioHang = _db.GioHang.Include("SanPham").
                                            Where(gh => gh.ApplicationUserId == claim.Value)
                                            .ToList();
            return View(dsGioHang);
        }
    }
}


using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project1.Data;

public class TheLoaiViewComponent: ViewComponent
{
    private readonly ApplicationDbContext _db;
    public TheLoaiViewComponent (ApplicationDbContext db)
    {
    _db = db;
    }
    public async Task<IViewComponentResult> InvokeAsync()
    {
    var theloai = await _db.TheLoai.ToListAsync();
    return View(theloai);
    }
}
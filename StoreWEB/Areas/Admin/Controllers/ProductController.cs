using Microsoft.AspNetCore.Mvc;
using StoreWEB.Areas.Admin.Models.Products;
using StoreWEB.DAL;

namespace StoreWEB.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            GetAdminProductVM prod = new GetAdminProductVM(
                );
            return View();
        }
    }
}

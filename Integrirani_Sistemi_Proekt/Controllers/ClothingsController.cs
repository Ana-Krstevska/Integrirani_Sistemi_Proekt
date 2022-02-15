using Integrirani_Sistemi_Proekt.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Integrirani_Sistemi_Proekt.Controllers
{
    public class ClothingsController : Controller
    {
        private readonly AppDbContext _context;

        public ClothingsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allClothings = await _context.Clothings.Include(n => n.Shop).Include(n => n.Brand).OrderBy(n => n.Name).ToListAsync();
            return View(allClothings);
        }
    }
}

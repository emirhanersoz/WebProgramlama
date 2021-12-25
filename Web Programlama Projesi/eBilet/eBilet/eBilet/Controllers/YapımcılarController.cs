using eBilet.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBilet.Controllers
{
    public class YapımcılarController : Controller
    {
        private readonly AppDbContext _context;
        public YapımcılarController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var bütünYapımcılar = await _context.Yapımcılar.ToListAsync();
            return View(bütünYapımcılar);
        }
    }
}

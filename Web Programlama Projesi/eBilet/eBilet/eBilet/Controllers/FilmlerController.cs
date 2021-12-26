using eBilet.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBilet.Controllers
{
    public class FilmlerController : Controller
    {
        private readonly AppDbContext _context;
        public FilmlerController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var bütünFilmler = await _context.Filmler.Include(n => n.Sinema).OrderBy(n => n.İsim).ToListAsync();
            return View(bütünFilmler);
        }
    }
}

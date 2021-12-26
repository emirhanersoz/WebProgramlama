using eBilet.Data;
using eBilet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBilet.Controllers
{
    public class SinemalarController : Controller
    {
        private readonly AppDbContext _context;
        public SinemalarController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var bütünSinemalar = await _context.Sinemalar.ToListAsync();
            return View(bütünSinemalar);
        }
    }
}

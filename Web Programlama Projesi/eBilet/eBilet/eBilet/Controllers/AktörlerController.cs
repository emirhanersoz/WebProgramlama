using eBilet.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBilet.Controllers
{
    public class AktörlerController : Controller
    {
        private readonly AppDbContext _context;

        public AktörlerController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Aktörler.ToList();
            return View(data);
        }
    }
}

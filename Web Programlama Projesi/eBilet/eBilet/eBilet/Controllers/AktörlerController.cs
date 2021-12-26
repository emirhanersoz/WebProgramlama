using eBilet.Data;
using eBilet.Data.Static;
using eBilet.Data.Services;
using eBilet.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eTickets.Data.Static;

namespace eBilet.Controllers
{ 
    [Authorize(Roles = UserRoles.Admin)]
    public class AktörlerController : Controller
    {
       
        private readonly IAktörlerService _service;

        public AktörlerController(IAktörlerService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var data = await _service.HepsiniAlAsync();
            return View(data);
        }
        public IActionResult Oluştur()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Oluştur([Bind("AdSoyad, ProfilResmiURL,Bio")]Aktör aktör)
        {
            if(ModelState.IsValid)
            {
                return View(aktör);
            }
            await _service.EkleAsync(aktör);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Detaylar(int id)
        {
            var aktörDetaylar = await _service.IdİleAlAsync(id);

            if (aktörDetaylar == null) return View("Bulunamadı");
            return View(aktörDetaylar);
        }

        public async Task<IActionResult> Düzenle(int id)
        {
            var aktörDetaylar = await _service.IdİleAlAsync(id);
            if (aktörDetaylar == null) return View("Bulunamadı");
            return View(aktörDetaylar);
        }

        [HttpPost]
        public async Task<IActionResult> Düzenle(int id,[Bind("AdSoyad, ProfilResmiURL,Bio")] Aktör aktör)
        {
            if (ModelState.IsValid)
            {
                return View(aktör);
            }
            await _service.GüncelleAsync(id, aktör);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Sil(int id)
        {
            var aktörDetaylar = await _service.IdİleAlAsync(id);
            if (aktörDetaylar == null) return View("Bulunamadı");
            return View(aktörDetaylar);
        }

        [HttpPost, ActionName("Sil")]
        public async Task<IActionResult> SilmeOnaylandı(int id, [Bind("AdSoyad, ProfilResmiURL,Bio")] Aktör aktör)
        {
            var aktörDetaylar = await _service.HepsiniAlAsync();
            if (aktörDetaylar == null) return View("Bulunamadı") ;

            await _service.SilAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

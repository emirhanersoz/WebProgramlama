using eBilet.Data.Cart;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBilet.Data.ViewComponents
{
    public class AlışverişSepetiÖzeti:ViewComponent
    {
        private readonly AlışverişSepeti _alışverişSepeti;
        public AlışverişSepetiÖzeti(AlışverişSepeti alışverişSepeti)
        {
            _alışverişSepeti = alışverişSepeti;
        }

        public IViewComponentResult Invoke()
        {
            var items = _alışverişSepeti.GetShoppingCartItems();

            return View(items.Count);
        }
    }
}

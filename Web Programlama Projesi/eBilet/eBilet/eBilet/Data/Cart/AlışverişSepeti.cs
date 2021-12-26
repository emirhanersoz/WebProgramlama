using eBilet.Models;
using eBilet.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBilet.Data.Cart
{
    public class ShoppingCart
    {
        public AppDbContext _context { get; set; }

        public string AlışverişSepetId { get; set; }
        public List<AlışverişSepetiÜrün> AlışverişSepetiÜrün { get; set; }

        public ShoppingCart(AppDbContext context)
        {
            _context = context;
        }

        public static ShoppingCart GetShoppingCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);

            return new ShoppingCart(context) { AlışverişSepetId = cartId };
        }

        public void AddItemToCart(Film Film)
        {
            var shoppingCartItem = _context.AlışverişSepetiÜrünler.FirstOrDefault(n => n.Film.Id == Film.Id && n.AlışverişSepetiId == AlışverişSepetId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new AlışverişSepetiÜrün()
                {
                    AlışverişSepetiId = AlışverişSepetId,
                    Film = Film,
                    Miktar = 1
                };

                _context.AlışverişSepetiÜrünler.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Miktar++;
            }
            _context.SaveChanges();
        }

        public void RemoveItemFromCart(Film Film)
        {
            var shoppingCartItem = _context.AlışverişSepetiÜrünler.FirstOrDefault(n => n.Film.Id == Film.Id && n.AlışverişSepetiId == AlışverişSepetId);

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Miktar > 1)
                {
                    shoppingCartItem.Miktar--;
                }
                else
                {
                    _context.AlışverişSepetiÜrünler.Remove(shoppingCartItem);
                }
            }
            _context.SaveChanges();
        }

        public List<AlışverişSepetiÜrün> GetShoppingCartItems()
        {
            return AlışverişSepetiÜrün ?? (AlışverişSepetiÜrün = _context.AlışverişSepetiÜrünler.Where(n => n.AlışverişSepetiId == n.AlışverişSepetiId).Include(n => n.Film).ToList());
        }

        public double GetShoppingCartTotal() => _context.AlışverişSepetiÜrünler.Where(n => n.AlışverişSepetiId == AlışverişSepetId).Select(n => n.Film.Fiyat * n.Miktar).Sum();

        public async Task ClearShoppingCartAsync()
        {
            var items = await _context.AlışverişSepetiÜrünler.Where(n => n.AlışverişSepetiId == AlışverişSepetId).ToListAsync();
            _context.AlışverişSepetiÜrünler.RemoveRange(items);
            await _context.SaveChangesAsync();
        }
    }
}

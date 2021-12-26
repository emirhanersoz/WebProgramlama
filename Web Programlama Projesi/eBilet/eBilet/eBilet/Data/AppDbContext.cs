using eBilet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBilet.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aktör_Film>().HasKey(af => new
            {
                af.AktörId,
                af.FilmId
            });

            modelBuilder.Entity<Aktör_Film>().HasOne(f => f.Film).WithMany(af => af.Aktörler_Filmler).HasForeignKey(f => f.FilmId);
            modelBuilder.Entity<Aktör_Film>().HasOne(f => f.Aktör).WithMany(af => af.Aktörler_Filmler).HasForeignKey(f => f.AktörId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Aktör> Aktörler { get; set; }
        public DbSet<Film> Filmler { get; set; }
        public DbSet<Aktör_Film> Aktörler_Filmler { get; set; }
        public DbSet<Sinema> Sinemalar { get; set; }
        public DbSet<Yapımcı> Yapımcılar { get; set; }

        public DbSet<Sipariş> Siparişler { get; set; }
        public DbSet<SiparişÜrün> SiparişÜrünler { get; set; }
        public DbSet<AlışverişSepetiÜrün> AlışverişSepetiÜrünler { get; set; }
    }
}

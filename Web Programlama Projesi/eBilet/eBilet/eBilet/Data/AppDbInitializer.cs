using eBilet.Data;
using eBilet.Data.Static;
using eBilet.Models;
using eTickets.Data.Static;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Sinemalar.Any())
                {
                    context.Sinemalar.AddRange(new List<Sinema>()
                    {
                        new Sinema()
                        {
                            İsim = "Cinema 1",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Açıklama = "This is the description of the first cinema"
                        },
                        new Sinema()
                        {
                            İsim = "Cinema 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Açıklama = "This is the description of the first cinema"
                        },
                        new Sinema()
                        {
                            İsim = "Cinema 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Açıklama = "This is the description of the first cinema"
                        },
                        new Sinema()
                        {
                            İsim = "Cinema 4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Açıklama = "This is the description of the first cinema"
                        },
                        new Sinema()
                        {
                            İsim = "Cinema 5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Açıklama = "This is the description of the first cinema"
                        },
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Aktörler.Any())
                {
                    context.Aktörler.AddRange(new List<Aktör>()
                    {
                        new Aktör()
                        {
                            AdSoyad = "Actor 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilResmiURL = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new Aktör()
                        {
                            AdSoyad = "Actor 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilResmiURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Aktör()
                        {
                            AdSoyad = "Actor 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilResmiURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Aktör()
                        {
                            AdSoyad = "Actor 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilResmiURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Aktör()
                        {
                            AdSoyad = "Actor 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilResmiURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Yapımcılar.Any())
                {
                    context.Yapımcılar.AddRange(new List<Yapımcı>()
                    {
                        new Yapımcı()
                        {
                            AdSoyad = "Producer 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilResmiURL = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new Yapımcı()
                        {
                            AdSoyad = "Producer 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilResmiURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Yapımcı()
                        {
                            AdSoyad = "Producer 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilResmiURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Yapımcı()
                        {
                            AdSoyad = "Producer 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilResmiURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Yapımcı()
                        {
                            AdSoyad = "Producer 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilResmiURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Filmler.Any())
                {
                    context.Filmler.AddRange(new List<Film>()
                    {
                        new Film()
                        {
                            İsim = "Life",
                            Açıklama = "This is the Life movie description",
                            Fiyat = 39.50,
                            ResimURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            BaşlangıçTarihi = DateTime.Now.AddDays(-10),
                            BitişTarihi = DateTime.Now.AddDays(10),
                            SinemaId = 3,
                            YapımcıId = 3,
                            FilmKategori = FilmKategori.Belgesel
                        },
                        new Film()
                        {
                            İsim = "The Shawshank Redemption",
                            Açıklama = "This is the Shawshank Redemption description",
                            Fiyat = 29.50,
                            ResimURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            BaşlangıçTarihi = DateTime.Now,
                            BitişTarihi = DateTime.Now.AddDays(3),
                            SinemaId = 1,
                            YapımcıId = 1,
                            FilmKategori = FilmKategori.Aksiyon
                        },
                        new Film()
                        {
                            İsim = "Ghost",
                            Açıklama = "This is the Ghost movie description",
                            Fiyat = 39.50,
                            ResimURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            BaşlangıçTarihi = DateTime.Now,
                            BitişTarihi = DateTime.Now.AddDays(7),
                            SinemaId = 4,
                            YapımcıId = 4,
                            FilmKategori = FilmKategori.Korku
                        },
                        new Film()
                        {
                            İsim = "Race",
                            Açıklama = "This is the Race movie description",
                            Fiyat = 39.50,
                            ResimURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            BaşlangıçTarihi = DateTime.Now.AddDays(-10),
                            BitişTarihi = DateTime.Now.AddDays(-5),
                            SinemaId = 1,
                            YapımcıId = 2,
                            FilmKategori = FilmKategori.Belgesel
                        },
                        new Film()
                        {
                            İsim = "Scoob",
                            Açıklama = "This is the Scoob movie description",
                            Fiyat = 39.50,
                            ResimURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            BaşlangıçTarihi = DateTime.Now.AddDays(-10),
                            BitişTarihi = DateTime.Now.AddDays(-2),
                            SinemaId = 1,
                            YapımcıId = 3,
                            FilmKategori = FilmKategori.ÇizgiFilm
                        },
                        new Film()
                        {
                            İsim = "Cold Soles",
                            Açıklama = "This is the Cold Soles movie description",
                            Fiyat = 39.50,
                            ResimURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            BaşlangıçTarihi = DateTime.Now.AddDays(3),
                            BitişTarihi = DateTime.Now.AddDays(20),
                            SinemaId = 1,
                            YapımcıId = 5,
                            FilmKategori = FilmKategori.Dram
                        }
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Aktörler_Filmler.Any())
                {
                    context.Aktörler_Filmler.AddRange(new List<Aktör_Film>()
                    {
                        new Aktör_Film()
                        {
                            AktörId = 1,
                            FilmId = 1
                        },
                        new Aktör_Film()
                        {
                            AktörId = 3,
                            FilmId = 1
                        },

                         new Aktör_Film()
                        {
                            AktörId = 1,
                            FilmId = 2
                        },
                         new Aktör_Film()
                        {
                            AktörId = 4,
                            FilmId = 2
                        },

                        new Aktör_Film()
                        {
                            AktörId = 1,
                            FilmId = 3
                        },
                        new Aktör_Film()
                        {
                            AktörId = 2,
                            FilmId = 3
                        },
                        new Aktör_Film()
                        {
                            AktörId = 5,
                            FilmId = 3
                        },


                        new Aktör_Film()
                        {
                            AktörId = 2,
                            FilmId = 4
                        },
                        new Aktör_Film()
                        {
                            AktörId = 3,
                            FilmId = 4
                        },
                        new Aktör_Film()
                        {
                            AktörId = 4,
                            FilmId = 4
                        },


                        new Aktör_Film()
                        {
                            AktörId = 2,
                            FilmId = 5
                        },
                        new Aktör_Film()
                        {
                            AktörId = 3,
                            FilmId = 5
                        },
                        new Aktör_Film()
                        {
                            AktörId = 4,
                            FilmId = 5
                        },
                        new Aktör_Film()
                        {
                            AktörId = 5,
                            FilmId = 5
                        },


                        new Aktör_Film()
                        {
                            AktörId = 3,
                            FilmId = 6
                        },
                        new Aktör_Film()
                        {
                            AktörId = 4,
                            FilmId = 6
                        },
                        new Aktör_Film()
                        {
                            AktörId = 5,
                            FilmId = 6
                        },
                    });
                    context.SaveChanges();
                }
            }

        }

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {

                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<UgulamaKullanıcı>>();
                string adminUserEmail = "admin@ebilet.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if(adminUser == null)
                {
                    var newAdminUser = new UgulamaKullanıcı()
                    {
                        AdSoyad = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }


                string appUserEmail = "user@ebilet.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new UgulamaKullanıcı()
                    {
                        AdSoyad = "Application User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        }
    }
}

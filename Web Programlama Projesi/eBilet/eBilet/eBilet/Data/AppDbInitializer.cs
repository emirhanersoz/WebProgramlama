using eBilet.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBilet.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using var serviceScope = applicationBuilder.ApplicationServices.CreateScope();
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                if(!context.Sinemalar.Any())
                {
                    context.Sinemalar.AddRange(new List<Sinema>()
                    {
                        new Sinema()
                        {
                            İsim = "Sinema 1",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Açıklama = "This is the description of the first cinema"
                        },
                        new Sinema()
                        {
                            İsim = "Sinema 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Açıklama = "This is the description of the first cinema"
                        },
                        new Sinema()
                        {
                            İsim = "Sinema 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Açıklama = "This is the description of the first cinema"
                        },
                        new Sinema()
                        {
                            İsim = "Sinema 4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Açıklama = "This is the description of the first cinema"
                        },
                        new Sinema()
                        {
                            İsim = "Sinema 5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Açıklama = "This is the description of the first cinema"
                        },
                    });
                    context.SaveChanges();
                }

                if (!context.Aktörler.Any())
                {
                    context.Aktörler.AddRange(new List<Aktör>()
                    {
                        new Aktör()
                        {
                            AdSoyad = "Aktör 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilResmiURL = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new Aktör()
                        {
                            AdSoyad = "Aktör 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilResmiURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Aktör()
                        {
                            AdSoyad = "Aktör 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilResmiURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Aktör()
                        {
                            AdSoyad = "Aktör 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilResmiURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Aktör()
                        {
                            AdSoyad = "Aktör 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilResmiURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }

                if (!context.Yapımcılar.Any())
                {
                    context.Yapımcılar.AddRange(new List<Yapımcı>()
                    {
                        new Yapımcı()
                        {
                            AdSoyad = "Yapımcı 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilResmiURL = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new Yapımcı()
                        {
                            AdSoyad = "Yapımcı 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilResmiURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Yapımcı()
                        {
                            AdSoyad = "Yapımcı 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilResmiURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Yapımcı()
                        {
                            AdSoyad = "Yapımcı 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilResmiURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Yapımcı()
                        {
                            AdSoyad = "Yapımcı 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilResmiURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }

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
    }
}

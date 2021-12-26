using eBilet.Data;
using eBilet.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eBilet.Models
{
    public class YeniFilmVM
    {
        public int Id { get; set; }

        [Display(Name = "Film Adı")]
        [Required(ErrorMessage = "İsim gerekli")]
        public string İsim { get; set; }

        [Display(Name = "Film Açıklaması")]
        [Required(ErrorMessage = "Açıklama gerekli")]
        public string Açıklama { get; set; }

        [Display(Name = "Fiyat")]
        [Required(ErrorMessage = "Fiyat gerekli")]
        public double Fiyat { get; set; }

        [Display(Name = "Film poster url")]
        [Required(ErrorMessage = "Film posteri gerekli")]
        public string ResimUrl { get; set; }

        [Display(Name = "Film başlangıç tarihi")]
        [Required(ErrorMessage = "Başlangıç tarihi gerekli")]
        public DateTime BaşlangıçTarihi { get; set; }

        [Display(Name = "Film bitiş tarihi")]
        [Required(ErrorMessage = "Bitiş tarihi gerekli")]
        public DateTime BitişTarihi { get; set; }

        [Display(Name = "Kategori seç")]
        [Required(ErrorMessage = "Film kategorisi gerekli")]
        public FilmKategori FilmKategori { get; set; }

        [Display(Name = "Aktör(ler) seç")]
        [Required(ErrorMessage = "Film aktör(ler)i gerekli")]
        public List<int> AktörId { get; set; }

        [Display(Name = "Sinema seç")]
        [Required(ErrorMessage = "Sinema gerekli")]
        public int SinemaId { get; set; }

        [Display(Name = "Yapımcı seç")]
        [Required(ErrorMessage = "Yapımcı gerekli")]
        public int YapımcıId { get; set; }
    }
}

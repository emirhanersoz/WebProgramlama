using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eBilet.Models
{
    public class Yapımcı
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profil Fotoğrafı")]
        [Required(ErrorMessage = "Profil fotoğrafı gerekli")]
        public string ProfilResmiURL { get; set; }

        [Display(Name = "AdSoyad")]
        [Required(ErrorMessage = "Ad Soyad gerekli")]
        public string AdSoyad { get; set; }

        [Display(Name = "Biyografi")]
        [Required(ErrorMessage = "Biyografi gerekli")]
        public string Bio { get; set; }

        public List<Film> Filmler { get; set; }
    }
}

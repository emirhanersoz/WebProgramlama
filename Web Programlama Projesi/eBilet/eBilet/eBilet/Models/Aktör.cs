using eBilet.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eBilet.Models
{
    public class Aktör: IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profil Fotoğrafı URL")]
        [Required(ErrorMessage = "Profil Resmi Gereklidir")]
        public string ProfilResmiURL { get; set; }

        [Display(Name = "AdSoyad")]
        [Required(ErrorMessage = "Ad Soyad Gereklidir")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars")]
        public string AdSoyad { get; set; }

        [Display(Name = "Biyografi")]
        [Required(ErrorMessage = "Biyografi Gereklidir")]
        public string Bio { get; set; }

        public List<Aktör_Film> Aktörler_Filmler { get; set; }
    }
}

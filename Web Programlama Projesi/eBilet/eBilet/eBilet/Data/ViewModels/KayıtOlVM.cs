using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eBilet.Data.ViewModels
{
    public class KayıtOlVM
    {
        [Display(Name = "Ad Soyad")]
        [Required(ErrorMessage = "Ad Soyad gerekli")]
        public string AdSoyad { get; set; }

        [Display(Name = "Email adresi")]
        [Required(ErrorMessage = "Email adresi gerekli")]
        public string EmailAdres { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Şifre { get; set; }

        [Display(Name = "Şifreyi Onayla")]
        [Required(ErrorMessage = "Şifre onayı gerekli")]
        [DataType(DataType.Password)]
        [Compare("Şifre", ErrorMessage = "Parolalar uyuşmuyor")]
        public string ŞifreOnayı { get; set; }
    }
}

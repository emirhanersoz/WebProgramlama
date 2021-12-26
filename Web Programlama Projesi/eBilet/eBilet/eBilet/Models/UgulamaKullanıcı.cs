using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eBilet.Models
{
    public class UgulamaKullanıcı:IdentityUser
    {
        [Display(Name = "Ad Soyad")]
        public string AdSoyad { get; set; }
    }
}

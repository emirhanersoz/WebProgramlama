using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eBilet.Data.ViewModels
{
    public class GirişVM
    {
        [Display(Name = "Email Adresi")]
        [Required(ErrorMessage = "E-posta adresi gerekli ")]
        public string EmailAdres { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Şifre { get; set; }
    }
}

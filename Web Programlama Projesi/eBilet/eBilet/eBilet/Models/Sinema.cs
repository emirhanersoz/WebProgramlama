using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eBilet.Models
{
    public class Sinema
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Sinema Logo")]
        [Required(ErrorMessage = "Logosu gerekli")]
        public string Logo { get; set; }

        [Display(Name = "Sinema İsim")]
        [Required(ErrorMessage = "İsim gerekli")]
        public string İsim { get; set; }

        [Display(Name = "Açıklama")]
        [Required(ErrorMessage = "Açıklama gerekli")]
        public string Açıklama { get; set; }

        public List<Film> Filmler { get; set; }
    }
}

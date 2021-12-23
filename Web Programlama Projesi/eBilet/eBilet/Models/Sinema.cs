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
        public string Logo { get; set; }
        public string İsim { get; set; }
        public string Açıklama { get; set; }
    }
}

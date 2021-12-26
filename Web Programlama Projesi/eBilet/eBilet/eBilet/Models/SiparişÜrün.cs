using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eBilet.Models
{
    public class SiparişÜrün
    {
        [Key]
        public int Id { get; set; }

        public int Miktar { get; set; }
        public double Fiyat { get; set; }

        public int FilmId { get; set; }
        [ForeignKey("FilmId")]
        public Film Film { get; set; }

        public int SiparişId { get; set; }
        [ForeignKey("SiparişId")]
        public Sipariş Sipariş { get; set; }
    }
}

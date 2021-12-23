using eBilet.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eBilet.Models
{
    public class Film
    {
        [Key]
        public int Id { get; set; }
        public string İsim { get; set; }
        public string Açıklama { get; set; }
        public double Fiyat { get; set; }
        public string ResimURL { get; set; }
        public DateTime BaşlangıçTarihi { get; set; }
        public DateTime BitişTarihi { get; set; }
        public FilmKategori FilmKategori { get; set; }


    }
}

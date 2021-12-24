using eBilet.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        public List<Aktör_Film> Aktörler_Filmler { get; set; }

        public int SinemaId { get; set; }
        [ForeignKey("SinemaId")]
        public Sinema Sinema { get; set; }

        public int YapımcıId { get; set; }
        [ForeignKey("YapımcıId")]
        public Yapımcı Yapımcı { get; set; }
    }
}

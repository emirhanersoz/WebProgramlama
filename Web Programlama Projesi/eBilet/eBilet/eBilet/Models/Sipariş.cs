using eBilet.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eBilet.Models
{
    public class Sipariş
    {
        [Key]
        public int Id { get; set; }

        public string Email { get; set; }

        public string kullanıcıId { get; set; }
        [ForeignKey(nameof(kullanıcıId))]
        public UgulamaKullanıcı Kullanıcı { get; set; }

        public List<SiparişÜrün> SiparişÜrünler { get; set; }
    }
}

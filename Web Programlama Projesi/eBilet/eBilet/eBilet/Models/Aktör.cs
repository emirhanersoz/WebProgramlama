﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eBilet.Models
{
    public class Aktör
    {
        [Key]
        public int Id { get; set; }
        public string ProfilResmiURL { get; set; }
        public string AdSoyad { get; set; }
        public string Bio { get; set; }

        public List<Aktör_Film> Aktörler_Filmler { get; set; }

    }
}

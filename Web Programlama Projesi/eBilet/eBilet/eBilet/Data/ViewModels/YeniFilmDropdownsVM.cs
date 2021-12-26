using eBilet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBilet.Data.ViewModels
{
    public class YeniFilmDropdownsVM
    {
        public YeniFilmDropdownsVM()
        {
            Yapımcılar = new List<Yapımcı>();
            Sinemalar = new List<Sinema>();
            Aktörler = new List<Aktör>();
        }

        public List<Yapımcı> Yapımcılar { get; set; }
        public List<Sinema> Sinemalar { get; set; }
        public List<Aktör> Aktörler { get; set; }
    }
}

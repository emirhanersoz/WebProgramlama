using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBilet.Models
{
    public class Aktör_Film
    {
        public int FilmId { get; set; }
        public Film Film { get; set; }
        public int AktörId { get; set; }
        public Aktör Aktör { get; set; }

    }
}

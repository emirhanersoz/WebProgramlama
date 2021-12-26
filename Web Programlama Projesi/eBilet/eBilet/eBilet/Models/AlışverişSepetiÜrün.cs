using eBilet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eBilet.Models
{
    public class AlışverişSepetiÜrün
    {
        [Key]
        public int Id { get; set; }

        public Film Film { get; set; }
        public int Miktar { get; set; }


        public string AlışverişSepetiId { get; set; }
    }
}

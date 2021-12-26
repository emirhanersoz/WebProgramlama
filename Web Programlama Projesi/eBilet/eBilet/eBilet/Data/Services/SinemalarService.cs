using eBilet.Data;
using eBilet.Data.Base;
using eBilet.Models;
using eTickets.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBilet.Data.Services
{
    public class SinemalarService: EntityBaseRepository<Sinema>, ISinemalarService
    {
        public SinemalarService(AppDbContext context) : base(context)
        {
        }
    }
}

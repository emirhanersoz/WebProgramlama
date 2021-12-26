using eBilet.Data.Base;
using eBilet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBilet.Data.Services
{
    public class AktörlerService : EntityBaseRepository<Aktör>, IAktörlerService
    {
        public AktörlerService(AppDbContext context) : base(context) { }
    }
}

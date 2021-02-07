using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VetReserve.Models;

namespace VetReserve.Data
{
    public class ClientContext : DbContext
    {
        public ClientContext (DbContextOptions<ClientContext> options)
            :base(options)
        {

        }

        public DbSet<ClientModel> ClientModel { get; set; }
        public DbSet<VetReserve.Models.VetModel> VetModel { get; set; }
        public DbSet<VetReserve.Models.PatientCardModel> PatientCardModel { get; set; }
        public DbSet<VetReserve.Models.VisitModel> VisitModel { get; set; }
    }
}

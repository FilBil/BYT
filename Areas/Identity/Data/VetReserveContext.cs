using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VetReserve.Areas.Identity.Data;

namespace VetReserve.Data
{
    public class VetReserveContext : IdentityDbContext<VetReserveUser>
    {
        public VetReserveContext(DbContextOptions<VetReserveContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
          
        }
    }
}

using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VetReserve.Areas.Identity.Data;
using VetReserve.Data;

[assembly: HostingStartup(typeof(VetReserve.Areas.Identity.IdentityHostingStartup))]
namespace VetReserve.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<VetReserveContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("VetReserveContext")));

                services.AddDefaultIdentity<VetReserveUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = true;
                
                })
                    .AddEntityFrameworkStores<VetReserveContext>();
            });
        }
    }
}
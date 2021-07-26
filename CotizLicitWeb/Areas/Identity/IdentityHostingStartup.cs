using System;
using CotizLicitWeb.Areas.Identity.Data;
using CotizLicitWeb.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(CotizLicitWeb.Areas.Identity.IdentityHostingStartup))]
namespace CotizLicitWeb.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<CotizLicitDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DevConnection")));

                services.AddDefaultIdentity<CotizLicitWebUser>(options => { 
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireDigit = true;
                    options.Password.RequiredLength = 5;
                    options.Password.RequireLowercase = true;
                    options.Password.RequireUppercase = true;
                    options.Password.RequireNonAlphanumeric = true;
                }).AddEntityFrameworkStores<CotizLicitDbContext>();
            });
        }
    }
}
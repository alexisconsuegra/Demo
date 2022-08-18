using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using xPray.Areas.Identity.Data;
using xPray.Data;

[assembly: HostingStartup(typeof(xPray.Areas.Identity.IdentityHostingStartup))]
namespace xPray.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            //builder.ConfigureServices((context, services) => {
            //    services.AddDbContext<AppDbContext>(options =>
            //        options.UseSqlServer(
            //            context.Configuration.GetConnectionString("AppDbContextConnection")));

            //    services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
            //        .AddEntityFrameworkStores<AppDbContext>();
            //});
        }
    }
}
using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using New_EmotionalIntel.Areas.Identity.Data;
using New_EmotionalIntel.Data;

[assembly: HostingStartup(typeof(New_EmotionalIntel.Areas.Identity.IdentityHostingStartup))]
namespace New_EmotionalIntel.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<New_EmotionalIntelContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("New_EmotionalIntelContextConnection")));
                //colocar RequireConfirmedAccount a falso para não ser preciso confirmação de email
                services.AddDefaultIdentity<New_EmotionalIntelUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<New_EmotionalIntelContext>();
            });
        }
    }
}
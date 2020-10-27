using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using New_EmotionalIntel.Areas.Identity.Data;

namespace New_EmotionalIntel.Data
{
    public class New_EmotionalIntelContext : IdentityDbContext<New_EmotionalIntelUser>
    {
        public New_EmotionalIntelContext(DbContextOptions<New_EmotionalIntelContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}

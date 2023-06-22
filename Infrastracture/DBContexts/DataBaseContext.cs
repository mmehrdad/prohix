using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Prohix.Core.Entities.Identity;
using Prohix.Core.Entities.Students;
using Prohix.Infrastracture.Configurations;
using Prohix.Infrastracture.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prohix.Infrastracture.DBContexts
{
    public class DataBaseContext : IdentityDbContext<Student, Role, int>// IdentityDbContext<User>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server database
            options.UseSqlServer(AppConfig.GetConnectionString("WebRazorDatabase"));

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(IDbModelConfiguration).Assembly);
        }
        
    }
}

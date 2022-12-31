using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace InfraEstrutura
{
    public partial class SistemaDbContextFactory : IDesignTimeDbContextFactory<SistemaDbContext>
    {
        public SistemaDbContext CreateDbContext(string[] args)
        {

            IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();

            var optionsBuilder = new DbContextOptionsBuilder<SistemaDbContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("defaultconnection"),
                b => b.MigrationsAssembly(typeof(SistemaDbContext).Assembly.FullName));

            return new SistemaDbContext(optionsBuilder.Options);
        }
    }
}

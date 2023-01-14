using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace InfraEstrutura
{
    public class SistemaDbContextFactory : IDesignTimeDbContextFactory<SistemaDbContext>
    {
        public SistemaDbContext CreateDbContext(string[] args)
        {

            IConfiguration configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();

            var optionsBuilder = new DbContextOptionsBuilder<SistemaDbContext>();
            optionsBuilder.UseSqlServer(ConfigurationExtensions.GetConnectionString(configuration, "defaultconnection"),
                b => b.MigrationsAssembly(typeof(SistemaDbContext).Assembly.FullName));

            return new SistemaDbContext(optionsBuilder.Options);
        }
    }
}

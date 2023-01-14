using Dominio.Entity;
using Microsoft.EntityFrameworkCore;

namespace InfraEstrutura
{
    public class SistemaDbContext : DbContext
    {

        public SistemaDbContext(DbContextOptions<SistemaDbContext> options) : base(options)
        {

        }

        public DbSet<TipoTecnologia> TipoTecnologias { get; set; }
        public DbSet<Tecnologia> Tecnologias { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserTecnologia> UserTecnologias { get; set; }

        public DbSet<UserService> UserServices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserTecnologia>(e =>
            {
                e.HasKey(e => new { e.TecnologiaId, e.UserId });
            });


        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //// relacionamento Muitos para um entre user e tecnologia
        //modelBuilder.Entity<User>()
        //.HasMany(e => e.LstTecnologia)
        //.WithOne(e => e.Users)
        //.HasForeignKey("FK_User_Tecnologia")
        //.OnDelete(DeleteBehavior.SetNull);

        // relacionamento um para muitos entre tipotecnologia e tecnologia
        //modelBuilder.Entity<Tecnologia>()
        //.HasOne(e => e.TipoTecnologia)
        //.WithMany(c => c.LstTecnologia)
        //.OnDelete(DeleteBehavior.SetNull);
        //}
    }
}

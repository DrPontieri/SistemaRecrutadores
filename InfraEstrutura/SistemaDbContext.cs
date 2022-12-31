using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entity;
using System.Reflection.Emit;

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

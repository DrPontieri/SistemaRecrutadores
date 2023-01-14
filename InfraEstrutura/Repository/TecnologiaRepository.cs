using Dominio.Entity;
using Dominio.Interface;

namespace InfraEstrutura.Repository
{
    public class TecnologiaRepository : GenericRepository<Tecnologia>, ITecnologiaRepository
    {
        public TecnologiaRepository(SistemaDbContext dbContext) : base(dbContext)
        {
        }
    }
}

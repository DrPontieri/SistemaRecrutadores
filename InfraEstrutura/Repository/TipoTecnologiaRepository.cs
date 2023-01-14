using Dominio.Entity;
using Dominio.Interface;

namespace InfraEstrutura.Repository
{
    public class TipoTecnologiaRepository : GenericRepository<TipoTecnologia>, ITipoTecnologiaRepository
    {
        public TipoTecnologiaRepository(SistemaDbContext dbContext) : base(dbContext)
        {

        }
    }
}

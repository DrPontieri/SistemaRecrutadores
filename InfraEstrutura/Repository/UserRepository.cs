using Dominio.Entity;
using Dominio.Interface;

namespace InfraEstrutura.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(SistemaDbContext dbContext) : base(dbContext)
        {
        }
    }
}

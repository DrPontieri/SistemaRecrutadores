using Dominio;
using Dominio.Entity;
using Dominio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraEstrutura.Repository
{
    public class UserRepository: GenericRepository<User>, IUserRepository
    {
        public UserRepository(SistemaDbContext dbContext) : base(dbContext)
        {
        }
    }
}

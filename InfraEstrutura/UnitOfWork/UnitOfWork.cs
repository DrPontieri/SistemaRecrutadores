using Dominio.Interface;
using Dominio.UnitOfWork;
using InfraEstrutura.Repository;

namespace InfraEstrutura.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SistemaDbContext _dbContext;

        private IUserRepository? _userrepository;

        public UnitOfWork(SistemaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IUserRepository userRepository
        {
            get { return _userrepository = _userrepository ?? new UserRepository(_dbContext); }
        }


        public void Commit()
            => _dbContext.SaveChanges();

        public async Task CommitAsync()
            => await _dbContext.SaveChangesAsync();

        public void Rollback()
            => _dbContext.Dispose();

        public async Task RollbackAsync()
            => await _dbContext.DisposeAsync();
    }
}

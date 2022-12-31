using Dominio.Interface;
using Dominio.UnitOfWork;
using InfraEstrutura.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public IUserRepository UserRepository
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

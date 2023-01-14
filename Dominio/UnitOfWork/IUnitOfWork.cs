using Dominio.Interface;

namespace Dominio.UnitOfWork
{
    public interface IUnitOfWork
    {
        IUserRepository userRepository { get; }

        //ITipoTecnologiaRepository tipoTecnologiaRepository { get;} 

        //ITecnologiaRepository tecnologiaRepository { get; }

        void Commit();
        void Rollback();
        Task CommitAsync();
        Task RollbackAsync();
    }
}

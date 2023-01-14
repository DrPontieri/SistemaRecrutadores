using Dominio.Entity;
using Dominio.Interface;
using Dominio.UnitOfWork;
using System.Linq.Expressions;

namespace InfraEstrutura.Repository
{
    /// <summary>
    /// 
    /// </summary>
    public class UserService : IUserService
    {
        /// <summary>
        /// 
        /// </summary>
        public IUnitOfWork? _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;   
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        public void Add(User entity)
        {
            var us = new User
            {
                Id = entity.Id,
                Nome = entity.Nome,
                Empresa = entity.Empresa,
                Email = entity.Email
            };
            if (_unitOfWork != null)
            {
                _unitOfWork.userRepository.Add(entity);
                _unitOfWork.CommitAsync();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task AddAsync(User entity)
        {
            var us = new User
            {
                Id = entity.Id,
                Nome = entity.Nome,
                Empresa = entity.Empresa,
                Email = entity.Email
            };
            if (_unitOfWork != null)
            {
                _unitOfWork.userRepository.Add(entity);
                await _unitOfWork.CommitAsync();
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void AddRange(IEnumerable<User> entities)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task AddRangeAsync(IEnumerable<User> entities, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public User? Get(Expression<Func<User, bool>> expression)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<User> GetAll()
        {
            if (_unitOfWork != null)
                return (IEnumerable<User>)_unitOfWork.userRepository.GetAll();
            else
                return Enumerable.Empty<User>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public IEnumerable<User> GetAll(Expression<Func<User, bool>> expression)
        {
            if (_unitOfWork != null)
                return (IEnumerable<User>)_unitOfWork.userRepository.GetAll();
            else
                return Enumerable.Empty<User>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<IEnumerable<User>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            if (_unitOfWork != null)
                return await _unitOfWork.userRepository.GetAllAsync();
            else
                return Enumerable.Empty<User>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<IEnumerable<User>> GetAllAsync(Expression<Func<User, bool>> expression, CancellationToken cancellationToken = default)
        {
            if (_unitOfWork != null)
                return await _unitOfWork.userRepository.GetAllAsync(expression, cancellationToken);
            else
                return Enumerable.Empty<User>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<User?> GetAsync(Expression<Func<User, bool>> expression, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Remove(User entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void RemoveRange(IEnumerable<User> entities)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void Update(User entity)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void UpdateRange(IEnumerable<User> entities)
        {
            throw new NotImplementedException();
        }

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="user"></param>
        ///// <returns></returns>
        //public async Task AddUser(UserViewModel user)
        //{
        //    var us = new User
        //    {
        //        Id = user.Id,
        //        Nome= user.Nome,
        //        Empresa= user.Empresa,
        //        Email= user.Email,
        //    };
        //    if (_unitOfWork != null)
        //    {
        //        _unitOfWork.userRepository.Add(us);
        //        await _unitOfWork.CommitAsync();
        //    }           
        //}

        ///// <summary>
        ///// 
        ///// </summary>
        ///// <returns></returns>
        //public async Task<IEnumerable<User>> GetAll()
        //{
        //    if (_unitOfWork != null)
        //        return await _unitOfWork.userRepository.GetAllAsync();
        //    else
        //        return Enumerable.Empty<User>();
        //}


    }
}

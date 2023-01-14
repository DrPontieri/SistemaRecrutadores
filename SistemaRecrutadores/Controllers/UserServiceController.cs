using Dominio.Entity;
using Dominio.Interface;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace SistemaRecrutadores.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [EnableCors("MyPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserServiceController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        public IUserService _userService;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userService"></param>
        /// 

        public UserServiceController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _userService.GetAllAsync();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// 
        [HttpPost]
        public async Task AddAsync(User entity)
        {
            await _userService.AddAsync(entity);
        }
    }
}

using Dominio.Entity;

namespace SistemaRecrutadores.ViewModel
{
    /// <summary>
    /// 
    /// </summary>
    public partial class UserViewModel : BaseEntity
    {
        /// <summary>
        /// 
        /// </summary>
        public UserViewModel()
        {
            ListTecnologia = new HashSet<Tecnologia>();
        }
        /// <summary>
        /// 
        /// </summary>
        public String? Nome { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public String? Email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public String? Empresa { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual ICollection<Tecnologia> ListTecnologia { get; set; }
    }
}

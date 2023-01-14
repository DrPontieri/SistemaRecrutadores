using Dominio.Interface;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entity
{
    [NotMapped]
    public partial class UserService : BaseEntity
    {
        //public User()
        //{
        //    ListTecnologia = new HashSet<Tecnologia>();
        //    ListUserTecnologia = new HashSet<UserTecnologia>();
        //}
        public String? Nome { get; set; }
        public String? Email { get; set; }
        public String? Empresa { get; set; }

        //public virtual ICollection<Tecnologia> ListTecnologia { get; set; }

        //public virtual ICollection<UserTecnologia> ListUserTecnologia { get;set }
    }
}

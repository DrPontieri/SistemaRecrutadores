using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entity
{
    [Table("UserTecnologia")]
    public partial class UserTecnologia
    {
        public int UserId { get; set; }
        public User? User { get; set; }
        public int TecnologiaId { get; set; }
        public Tecnologia? Tecnologia { get; set; }
    }
}

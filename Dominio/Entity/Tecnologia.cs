using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entity
{
    [Table("Tecnologia")]
    public class Tecnologia : BaseEntity
    {
        public Tecnologia() 
        {
            ListUserTecnologia = new HashSet<UserTecnologia>();
        }
        [Column(TypeName = "varchar(200)")]
        public string? DescricaoTecnologia { get; set; }

        [ForeignKey("TipoTecnologia")]
        public int TipoTecnologiaID { get; set; }
        public virtual ICollection<UserTecnologia>? ListUserTecnologia { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entity
{
    [Table("TipoTecnologia")]
    public partial class TipoTecnologia : BaseEntity
    {
        //public TipoTecnologia()
        //{
        //    ListTecnologia = new HashSet<Tecnologia>();
        //}
        [Column(TypeName = "varchar(200)")]
        public string? Descricao { get; set; }

        //public ICollection<Tecnologia> ListTecnologia { get; set; }
    }
}

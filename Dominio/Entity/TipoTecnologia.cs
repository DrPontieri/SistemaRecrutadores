using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entity
{
    [Table("TipoTecnologia")]
    public partial class TipoTecnologia : BaseEntity
    {
        [Column(TypeName = "varchar(200)")]
        public string? Descricao { get; set; }

        public ICollection<Tecnologia>? Tecnologias { get; set; }

        public ICollection<User>? Users { get; set; }
    }
}

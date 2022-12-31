using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entity
{
    [Table("Tecnologia")]
    public class Tecnologia : BaseEntity
    {
        [Column(TypeName = "varchar(200)")]
        public string DescricaoTecnologia { get; set; }

        public TipoTecnologia TipoTecnologia { get; set; }


    }
}

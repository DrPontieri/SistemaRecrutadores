using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entity
{
    [Table("User")]
    public partial class User : BaseEntity
    {
        [Column(TypeName = "varchar(200)")]
        public String? Nome { get; set; }


        [Column(TypeName = "varchar(200)")]
        public String? Email { get; set; }


        [Column(TypeName = "varchar(200)")]
        public String? Empresa { get; set; }

        public TipoTecnologia TipoTecnologia { get; set; }
    }
}

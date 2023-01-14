﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entity
{
    [Table("User")]
    public partial class User : BaseEntity
    {
        //public User()
        //{
        //    ListTecnologia = new HashSet<Tecnologia>();
        //    ListUserTecnologia = new HashSet<UserTecnologia>();
        //}

        [Column(TypeName = "varchar(200)")]
        public String? Nome { get; set; }


        [Column(TypeName = "varchar(200)")]
        public String? Email { get; set; }


        [Column(TypeName = "varchar(200)")]
        public String? Empresa { get; set; }

        //public virtual ICollection<Tecnologia> ListTecnologia { get; set; }

        //public virtual ICollection<UserTecnologia> ListUserTecnologia { get;set }
    }
}

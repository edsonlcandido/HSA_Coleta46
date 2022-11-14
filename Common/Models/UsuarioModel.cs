using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;
using System.ComponentModel.DataAnnotations.Schema;

namespace Common.Models
{
    [Table("usuario")]
    public class UsuarioModel
    {
        [DisplayName("#")]
        [ReadOnly(true)]
        [Column("id")]
        public int id { get; set; }
        [DisplayName("Nome")]
        [Column("nome")]
        public string nome { get; set; }
        [DisplayName("Usuário ativo")]
        [Column("ativo")]
        public bool ativo { get; set; }
    }
}

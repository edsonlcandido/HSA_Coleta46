using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Common.Models
{
    public class UsuarioModel
    {
        [DisplayName("#")]
        [ReadOnly(true)]
        public int id { get; set; }
        [DisplayName("Nome")]
        public string nome { get; set; }
        [DisplayName("Usuário ativo")]
        public bool ativo { get; set; }
    }
}

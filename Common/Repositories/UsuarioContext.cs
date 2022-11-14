using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Core;

namespace Common.Repositories
{
    internal class UsuarioContext : DbContext, IUsuarioRepository
    {
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public IEnumerable<UsuarioModel> usuariosAtivos()
        {
            throw new NotImplementedException();
        }
    }
}

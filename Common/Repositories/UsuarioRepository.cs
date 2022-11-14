using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SQLite;

namespace Common.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public UsuarioRepository() 
        {            
        }
        public IEnumerable<UsuarioModel> usuariosAtivos()
        {
            List<UsuarioModel> usuariosAtivos = new List<UsuarioModel>();

            //var data = usuariosContext.ToList();
            //usuariosAtivos.AddRange(data);

            return usuariosAtivos;
            //throw new NotImplementedException();
        }
    }
}

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
        private readonly Context db;
        public UsuarioRepository() 
        {        
            db = new Context();
        }
        public IEnumerable<UsuarioModel> usuariosAtivos()
        {
            //List<UsuarioModel> usuariosAtivos = new List<UsuarioModel>();

            //var data = usuariosContext.ToList();
            //usuariosAtivos.AddRange(data);

            //foreach (var usuario in db.usuario.ToList())
            //{

            //}

            return db.usuario.ToList();
            //throw new NotImplementedException();
        }
    }
}

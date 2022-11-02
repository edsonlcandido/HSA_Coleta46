using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories
{
    public  class UsuarioRepositoryTextDb : IUsuarioRepository
    {
        public IEnumerable<UsuarioModel> usuariosAtivos()
        {
            List<UsuarioModel> usuarios = new List<UsuarioModel>();
            foreach (string user in System.IO.File.ReadLines(@"users.db"))
            {
                usuarios.Add(new UsuarioModel() { ativo = true, nome = user });
            }
            return usuarios;
        }
    }
}

using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories
{
    public class UsuarioRepositoryStatic : IUsuarioRepository
    {
        public IEnumerable<UsuarioModel> usuariosAtivos()
        {
            List<UsuarioModel> usuarios = new List<UsuarioModel>()
            {
                new UsuarioModel() { id = 1, nome = "edson", ativo = true },
                new UsuarioModel() {id=2, nome ="candided", ativo = true }
            };
            return usuarios;
        }
    }
}

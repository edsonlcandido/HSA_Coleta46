using Common.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Repositories
{
    public class UsuarioRepository: IUsuarioRepository
    {
        private static readonly string CONNECTION_STRING = @"Data Source=HSA_Coleta.db;";
        public static IEnumerable<UsuarioModel> listar()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UsuarioModel> usuariosAtivos()
        {
            List<UsuarioModel> usuarios = new List<UsuarioModel>();
            SQLiteConnection connection = new SQLiteConnection(CONNECTION_STRING);
            SQLiteCommand command = connection.CreateCommand();
            command.CommandText = $@"SELECT id,
                                            nome,
                                            ativo
                                        FROM usuarios
                                        WHERE ativo = 1;";
            connection.Open();
            using (SQLiteDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    UsuarioModel usuarioModel = new UsuarioModel();
                    usuarioModel.id = reader.GetInt32(0);
                    usuarioModel.nome = reader.GetString(1);
                    usuarioModel.ativo = reader.GetBoolean(2);
                    usuarios.Add(usuarioModel);
                }
            }
            connection.Close();
            return usuarios;
        }
    }
}

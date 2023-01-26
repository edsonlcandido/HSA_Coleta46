using Common.Models;
using Common.Presenters;
using Common.Repositories;
using HSA_Coleta;
using InserirColeta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministrarColeta
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string userName = Environment.UserName;
            IUsuarioRepository usuariorepository = new UsuarioRepository();
            IEnumerable<UsuarioModel> usuariosAtivos = usuariorepository.usuariosAtivos();
            try
            {
                UsuarioModel usuario = (UsuarioModel)usuariosAtivos.First(u => u.nome.ToLower().Contains(userName.ToLower()));
                Application.Run(new FormAdministrarColeta(usuario));
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Acesso negado, solicite acesso para administrar as coletas", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

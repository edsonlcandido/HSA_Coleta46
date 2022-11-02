using Common.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InserirColeta
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
            ColetaPresenter coletaPresenter = new ColetaPresenter();
            coletaPresenter.titulo = "Inserir coleta";
            coletaPresenter.editando = false;
            coletaPresenter.visualizando = false;
            Application.Run(new FormInserirColeta(coletaPresenter));
        }
    }
}

using Common.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common.Repositories

{
    public interface IColetaRepository
    {

        int adicionar(ColetaModel coletaModel);
        void editar(ColetaModel coletaModel);
        void deletar(int id);
        ColetaModel obterPeloId(int id);
        IEnumerable<ColetaModel> listar();
        IEnumerable<ColetaModel> listarTodasAguardando();

        IEnumerable<ColetaModel> filtrarPeloStatus(string status);

    }
}
using Common.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Presenters
{
    public class ColetaPresenter : IColetaView
    {
        public int id { get ; set ; }
        public DateTime dataInclusao { get ; set ; }
        public string solicitante { get ; set ; }
        public string setor { get ; set ; }
        public string CC_Projeto { get ; set ; }
        public DateTime dataNecessaria { get ; set ; }
        public string periodoColeta { get ; set ; }
        public string localColeta { get ; set ; }
        public string enderecoColeta { get ; set ; }
        public string localEntrega { get ; set ; }
        public string enderecoEntrega { get ; set ; }
        public string materialDescricao { get ; set ; }
        public string materialDimensoes { get ; set ; }
        public double materialPeso { get ; set ; }
        public int quantidadeVolume { get ; set ; }
        public string obs { get ; set ; }
        public string notaFiscal { get ; set ; }
        public double valorNotaFiscal { get ; set ; }
        public string transportadora { get ; set ; }
        public double valorFrete { get ; set ; }
        public DateTime dataColeta { get ; set ; }
        public string status { get ; set ; }
        public string motivoFalha { get ; set ; }
        public bool editando { get ; set ; }
        public bool visualizando { get ; set ; }
        public string titulo { get ; set ; }
    }
}

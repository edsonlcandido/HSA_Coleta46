using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;

namespace Common.Views
{
    public interface IColetaView
    {
         int id { get; set; }
         DateTime dataInclusao { get; set; }
         string solicitante { get; set; }
         string setor { get; set; }
         string CC_Projeto { get; set; }
         DateTime dataNecessaria { get; set; }
         string periodoColeta { get; set; }
         string localColeta { get; set; }
         string enderecoColeta { get; set; }
         string localEntrega { get; set; }
         string enderecoEntrega { get; set; }
         string materialDescricao { get; set; }
         string materialDimensoes { get; set; }
         double materialPeso { get; set; }
         int quantidadeVolume { get; set; }
         string obs { get; set; }
         string notaFiscal { get; set; }
         double valorNotaFiscal { get; set; }
         string transportadora { get; set; }
         double valorFrete { get; set; }
         DateTime dataColeta { get; set; }
         string status { get; set; }
         string motivoFalha { get; set; }
         bool editando { get; set; }
        bool visualizando { get; set; }
        string titulo { get; set; }
    }
}

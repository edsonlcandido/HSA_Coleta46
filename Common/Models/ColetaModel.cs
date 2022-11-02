using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{
    public class ColetaModel
    {
        [DisplayName("ID da coleta")]
        [Browsable(false)]
        [ReadOnly(true)]
        public int id { get; set; }
        [DisplayName("Data da inclusão")]
        [Required(ErrorMessage ="Data é requerida")]
        [Browsable(false)]
        [ReadOnly(true)]
        public DateTime dataInclusao { get; set; }
        [DisplayName("Solicitante email:")]
        [Required(ErrorMessage = "Solicitante é requerido")]
        public string solicitante { get; set; }
        [DisplayName("Setor")]
        [Required(ErrorMessage = "Setor é requerido")]
        public string setor { get; set; }
        [DisplayName("CC ou Projeto")]
        [Required(ErrorMessage = "CC / Projeto é requerido")]
        public string CC_Projeto { get; set; }
        [DisplayName("Data da necessidade")]
        [Required(ErrorMessage = "Data de necessidade é requerido")]
        public DateTime dataNecessaria { get; set; }
        [DisplayName("Período")]
        [Required(ErrorMessage = "Período é requerido")]
        public string periodoColeta { get; set; }
        [DisplayName("Local de coleta")]
        [Required(ErrorMessage = "Local de coleta é requerido")]
        public string localColeta { get; set; }
        [DisplayName("Endereço de coleta")]
        [Required(ErrorMessage = "Endereço de coleta é requerido")]
        [Browsable(false)]
        public string enderecoColeta { get; set; }
        [DisplayName("Local de entrega")]
        [Required(ErrorMessage = "Local de entrega é requerido")]
        public string localEntrega { get; set; }
        [DisplayName("Endereço de entrega")]
        [Required(ErrorMessage = "Endereço de entrega é requerido")]
        [Browsable(false)]
        public string enderecoEntrega { get; set; }
        [DisplayName("Descrição do material")]
        [Required(ErrorMessage = "Descrição do material é requerido")]
        public string materialDescricao { get; set; }
        [DisplayName("Dimensões do material CxLxA [mm]")]
        [Required(ErrorMessage = "Dimensões do material é requerido")]
        public string materialDimensoes { get; set; }
        [DisplayName("Peso do material [kg]")]
        [Required(ErrorMessage = "Peso do material é requerido")]
        public double materialPeso { get; set; }
        [DisplayName("Quantidade de volumes")]
        [Required(ErrorMessage = "Quantidade de volumes é requerido")]
        public int quantidadeVolume { get; set; }
        [DisplayName("Observações")]
        [Required(ErrorMessage = "Observação é requerido")]
        public string obs { get; set; }
        [DisplayName("Numero da nota fiscal")]
        [Required(ErrorMessage = "Número de nota fiscal é requerido")]
        public string notaFiscal { get; set; }
        [DisplayName("Valor da NF [R$]")]
        [Required(ErrorMessage = "Valor de nota fiscal é requerido")]
        public double valorNotaFiscal { get; set; }
        [DisplayName("Nome da transportadora")]
        [Browsable(false)]
        public string transportadora { get; set; }
        [DisplayName("Valor do frete [R$]")]
        [Browsable(false)]
        public double valorFrete { get; set; }
        [DisplayName("Data da coleta")]
        [Browsable(false)]
        public DateTime dataColeta { get; set; }
        [DisplayName("Status da coleta")]        
        public string status { get; set; }
        [DisplayName("Motivo de falha")]
        [Browsable(false)]
        public string motivoFalha { get; set; }
    }

}

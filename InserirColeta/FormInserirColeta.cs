using Common.Controllers;
using Common.Models;
using Common.Repositories;
using Common.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InserirColeta
{
    public partial class FormInserirColeta : Form, IColetaView
    {
        private int _HORA_MINIMA_PARA_SOLICITAR_HOJE = 14;
        private IColetaRepository _coletaRepository;
        private IColetaView _coletaView;
        private readonly bool _visualizando;
        private readonly bool _editando;
        private readonly string _titulo;
        private ColetaModel _coletaModel;
        public FormInserirColeta(IColetaView view)
        {
            _coletaRepository = new ColetaRepository();
            _coletaView = view;
            _visualizando = view.visualizando;
            _editando = view.editando;
            _titulo = view.titulo;
            _coletaModel = new ColetaModel();
            InitializeComponent();
        }
        public FormInserirColeta(IColetaView view, ColetaModel coletaModel)
        {
            _coletaRepository = new ColetaRepository();
            _coletaView = view;
            _visualizando = view.visualizando;
            _editando = view.editando;
            _titulo = view.titulo;
            _coletaModel = coletaModel;
            InitializeComponent();
            this.id = coletaModel.id;
            this.dataInclusao = coletaModel.dataInclusao;
            this.solicitante = coletaModel.solicitante;
            this.setor = coletaModel.setor;
            this.CC_Projeto = coletaModel.CC_Projeto;
            this.dataNecessaria = coletaModel.dataNecessaria;
            this.periodoColeta = coletaModel.periodoColeta;
            this.localColeta = coletaModel.localColeta;
            this.enderecoColeta = coletaModel.enderecoColeta;
            this.localEntrega = coletaModel.localEntrega;
            this.enderecoEntrega = coletaModel.enderecoEntrega;
            this.materialDescricao = coletaModel.materialDescricao;
            this.materialDimensoes = coletaModel.materialDimensoes;
            this.materialPeso = coletaModel.materialPeso;
            this.quantidadeVolume = coletaModel.quantidadeVolume;
            this.notaFiscal = coletaModel.notaFiscal;
            this.valorNotaFiscal = coletaModel.valorNotaFiscal;
            this.obs = coletaModel.obs;
            this.transportadora = coletaModel.transportadora;
            this.valorFrete = coletaModel.valorFrete;
            this.dataColeta = coletaModel.dataColeta;
            this.status = coletaModel.status;   
            this.motivoFalha = coletaModel.motivoFalha;
        }

        public int id { get { return Convert.ToInt32(textBoxId.Text); } set { textBoxId.Text = Convert.ToString(value); } }
        public DateTime dataInclusao { 
            get 
            {
                DateTime dataInclusao = DateTime.ParseExact(textBoxDataInclusao.Text, "dd/MM/yyyy",System.Globalization.CultureInfo.InvariantCulture);
                return dataInclusao;
            } 
            set 
            {
                DateTime dataInclusao = value;
                textBoxDataInclusao.Text = dataInclusao.ToString("dd/MM/yyyy");
            } 
        }
        public string solicitante { get => textBoxSolicitante.Text; set => textBoxSolicitante.Text = value; }
        public string setor { get => textBoxSetor.Text; set => textBoxSetor.Text = value; }
        public string CC_Projeto { get => textBox_CC_Projeto.Text; set => textBox_CC_Projeto.Text = value; }
        public DateTime dataNecessaria
        {
            get
            {
                DateTime dataNecessario = DateTime.ParseExact(dateTimePickerDataNecessesaria.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                switch (this.periodoColeta)
                {
                    case "manhã":
                        dataNecessario = dataNecessario.AddHours(8);
                        break;
                    case "tarde":
                        dataNecessario = dataNecessario.AddHours(13);
                        break;
                    case "noite":
                        dataNecessario = dataNecessario.AddHours(18);
                        break;
                    default:
                        break;
                }
                return dataNecessario;
            }
            set
            {
                DateTime dateTime = value;
                dateTimePickerDataNecessesaria.Value = dateTime;
            }
        }
        public string periodoColeta { get => comboBoxPeriodo.Text; set => comboBoxPeriodo.Text = value; }
        public string localColeta { get => textBoxLocalColeta.Text; set => textBoxLocalColeta.Text = value; }
        public string enderecoColeta { get => textBoxEnderecoColeta.Text; set => textBoxEnderecoColeta.Text = value; }
        public string localEntrega { get => textBoxLocalEntrega.Text; set => textBoxLocalEntrega.Text = value; }
        public string enderecoEntrega { get => textBoxEnderecoEntrega.Text; set => textBoxEnderecoEntrega.Text = value; }
        public string materialDescricao { get => textBoxMaterialDescricao.Text; set => textBoxMaterialDescricao.Text = value; }
        public string materialDimensoes { get => textBoxMaterialDimensoes.Text; set => textBoxMaterialDimensoes.Text = value; }
        public double materialPeso 
        { 
            get 
            {
                return Convert.ToDouble(textBoxMaterialPeso.Text);
            }
            set 
            {
                double peso = value;
                textBoxMaterialPeso.Text = peso.ToString("N2");
            } 
        }
        public int quantidadeVolume {
            get 
            {
                return Convert.ToInt32(textBoxQuantidadeVolume.Text);
            }
            set
            {
                int volumes = value;
                textBoxQuantidadeVolume.Text = volumes.ToString();
            }
        }
        public string obs { get => textBoxObs.Text; set => textBoxObs.Text = value; }
        public string notaFiscal { get => textBoxNotaFiscal.Text; set => textBoxNotaFiscal.Text = value; }
        public double valorNotaFiscal {
            get {
                return Convert.ToDouble(textBoxValorNotaFiscal.Text); 
            }
            set {
                double valorNotaFiscal = value;
                textBoxValorNotaFiscal.Text = valorNotaFiscal.ToString();
            }
        }
        public string transportadora { get => textBoxTransportadora.Text; set => textBoxTransportadora.Text = value; }
        public double valorFrete {
            get
            {
                return Convert.ToDouble(textBoxValorFrete.Text);
            }
            set
            {
                double valorFrete = value;
                textBoxValorFrete.Text = valorFrete.ToString();
            }
        }
        public DateTime dataColeta
        {
            get
            {
                DateTime dataColeta = dateTimePickerDataColeta.Value;
                return dataColeta;
            }
            set
            {
                DateTime dateTime = value;
                dateTimePickerDataColeta.Value = value;
            }
        }
        public string status { get { return comboBoxStatus.Text; } set { comboBoxStatus.Text = value; } }
        public string motivoFalha { get => textBoxMotivoFalha.Text; set => textBoxMotivoFalha.Text = value;  }
        public bool editando { get => _coletaView.editando; set => _coletaView.editando = _editando; }
        public bool visualizando { get => _coletaView.visualizando; set => _coletaView.visualizando = _visualizando; }
        public string titulo { get => _coletaView.titulo; set => _coletaView.titulo = _titulo; }

        private void FormInserirColeta_Load(object sender, EventArgs e)
        {
            labelTitulo.Text = _coletaView.titulo;

            if (_coletaView.visualizando)
            {
                #region visualizando
                textBoxSolicitante.ReadOnly = _coletaView.visualizando;
                labelId.Visible = _coletaView.visualizando;
                textBoxId.Visible = _coletaView.visualizando;
                textBoxId.Enabled = _coletaView.visualizando;
                textBoxId.ReadOnly = _coletaView.visualizando;
                labelDataInclusão.Visible = _coletaView.visualizando;
                textBoxDataInclusao.Visible = _coletaView.visualizando;
                textBoxDataInclusao.Enabled = _coletaView.visualizando;
                textBoxDataInclusao.ReadOnly = _coletaView.visualizando;
                textBoxSetor.ReadOnly = _coletaView.visualizando;
                textBox_CC_Projeto.ReadOnly = _coletaView.visualizando;
                dateTimePickerDataNecessesaria.Enabled = !_coletaView.visualizando;
                dateTimePickerDataNecessesaria.CalendarTitleBackColor = Color.White;
                comboBoxPeriodo.Enabled = !_coletaView.visualizando;
                comboBoxPeriodo.BackColor = Color.White;
                textBoxLocalColeta.ReadOnly = _coletaView.visualizando;
                textBoxEnderecoColeta.ReadOnly = _coletaView.visualizando;
                textBoxLocalEntrega.ReadOnly = _coletaView.visualizando;
                textBoxEnderecoEntrega.ReadOnly = _coletaView.visualizando;
                textBoxMaterialDescricao.ReadOnly = _coletaView.visualizando;
                textBoxMaterialDimensoes.ReadOnly = _coletaView.visualizando;
                textBoxMaterialPeso.ReadOnly = _coletaView.visualizando;
                textBoxQuantidadeVolume.ReadOnly = _coletaView.visualizando;
                textBoxNotaFiscal.ReadOnly = _coletaView.visualizando;
                textBoxValorNotaFiscal.ReadOnly = _coletaView.visualizando;
                textBoxObs.ReadOnly = _coletaView.visualizando;
                labelTransportadora.Visible = _coletaView.visualizando;
                textBoxTransportadora.Visible = _coletaView.visualizando;
                textBoxTransportadora.Enabled = _coletaView.visualizando;
                textBoxTransportadora.ReadOnly = _coletaView.visualizando;
                labelValorFrete.Visible = _coletaView.visualizando;
                textBoxValorFrete.Visible = _coletaView.visualizando;
                textBoxValorFrete.Enabled = _coletaView.visualizando;
                textBoxValorFrete.ReadOnly = _coletaView.visualizando;
                labelDataColeta.Visible = _coletaView.visualizando;
                dateTimePickerDataColeta.Visible = _coletaView.visualizando;
                dateTimePickerDataColeta.Enabled = !_coletaView.visualizando;
                comboBoxStatus.Visible = _coletaView.visualizando;
                comboBoxStatus.Enabled = !_coletaView.visualizando;
                labelMotivoFalha.Visible = _coletaView.visualizando;
                textBoxMotivoFalha.Visible = _coletaView.visualizando;
                textBoxMotivoFalha.Enabled = _coletaView.visualizando;
                textBoxMotivoFalha.ReadOnly = _coletaView.visualizando;
                buttonIncluir.Visible = false;
                buttonSalvar.Visible = false;
                #endregion
            }
            else if (_coletaView.editando)
            {
                #region Editando
                textBoxTransportadora.Visible = _coletaView.editando;
                labelTransportadora.Visible = _coletaView.editando;
                labelValorFrete.Visible = _coletaView.editando;
                textBoxValorFrete.Visible = _coletaView.editando;
                labelDataColeta.Visible = _coletaView.editando;
                dateTimePickerDataColeta.Visible = _coletaView.editando;
                comboBoxStatus.Visible = _coletaView.editando;
                labelStatus.Visible = _coletaView.editando;
                labelMotivoFalha.Visible = _coletaView.editando;
                textBoxMotivoFalha.Visible = _coletaView.editando;
                textBoxId.Visible = _coletaView.editando;
                labelId.Visible = _coletaView.editando;
                labelDataInclusão.Visible = _coletaView.editando;
                textBoxDataInclusao.Visible = _coletaView.editando;
                buttonIncluir.Visible = false;
                buttonSalvar.Visible = true;
                #endregion
            }
            else
            {
                dataInclusao = DateTime.Now;
                int minHour = _HORA_MINIMA_PARA_SOLICITAR_HOJE;

                if (DateTime.Now.Hour > minHour)
                {
                    dateTimePickerDataNecessesaria.MinDate = DateTime.Now.AddDays(2);
                }
                else
                {
                    dateTimePickerDataNecessesaria.MinDate = DateTime.Now.AddDays(1);
                }

                labelId.Visible = false;
                textBoxId.Visible = false;
                labelDataInclusão.Visible = false;
                textBoxDataInclusao.Visible = false;
                labelTransportadora.Visible = false;
                textBoxTransportadora.Visible = false;
                labelValorFrete.Visible = false;
                textBoxValorFrete.Visible = false;
                labelDataColeta.Visible = false;
                dateTimePickerDataColeta.Visible = false;
                labelStatus.Visible = false;
                comboBoxStatus.Visible = false;
                labelMotivoFalha.Visible = false;
                textBoxMotivoFalha.Visible = false;
                buttonIncluir.Visible = true;
                buttonSalvar.Visible = false;

                labelCamposObrigatorios.Visible = true;
                labelSolicitante.Text += " *";
                labelSetor.Text += " *";
                label_CC_Projeto.Text += " *";
                labelDataNecessesaria.Text += " *";
                labelPeriodo.Text += " *";
                labelLocalColeta.Text += " *";
                labelEnderecoColeta.Text += " *";
                labelLocalEntrega.Text += " *";
                labelEndereçoEntrega.Text += " *";
                labelMaterialDescricao.Text += " *";
                labelMaterialDimensoes.Text += " *";
                labelMaterialPeso.Text += " *";
                labelQuantidadeVolumes.Text += " *";
                labelNotaFiscal.Text += " *";
                labelValorNotaFiscal.Text += " *";

                toolTip1.Active = true;
            }
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonIncluir_Click(object sender, EventArgs e)
        {
            viewToColetaModel();

            try
            {
                int  coletaId = _coletaRepository.adicionar(_coletaModel);
                MessageBox.Show($"#{coletaId} - Coleta incluída com sucesso", this.Text.ToString(),MessageBoxButtons.OK);
                IEmail email = new EmailController();
                ColetaModel coletaCriada = _coletaRepository.obterPeloId(coletaId);
                email.enviarEmailColetaAdicionada(coletaCriada);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),"ERRO" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            
        }

        private void viewToColetaModel()
        {
            try
            {
                _coletaModel.dataInclusao = this.dataInclusao;
                _coletaModel.solicitante = this.solicitante;
                _coletaModel.setor = this.setor;
                _coletaModel.CC_Projeto = this.CC_Projeto;
                _coletaModel.dataNecessaria = this.dataNecessaria;
                _coletaModel.periodoColeta = this.periodoColeta;
                _coletaModel.localColeta = this.localColeta;
                _coletaModel.enderecoColeta = this.enderecoColeta;
                _coletaModel.localEntrega = this.localEntrega;
                _coletaModel.enderecoEntrega = this.enderecoEntrega;
                _coletaModel.materialDescricao = this.materialDescricao;
                _coletaModel.materialDimensoes = this.materialDimensoes;
                _coletaModel.materialPeso = this.materialPeso;
                _coletaModel.quantidadeVolume = this.quantidadeVolume;
                _coletaModel.obs = this.obs;
                _coletaModel.notaFiscal = this.notaFiscal;
                _coletaModel.valorNotaFiscal = this.valorNotaFiscal;
                if (!this.editando)
                {
                    _coletaModel.status = "aguardando";
                }
                else
                {
                    _coletaModel.id = this.id;
                    _coletaModel.status = this.status;
                    _coletaModel.transportadora = this.transportadora;
                    _coletaModel.valorFrete = this.valorFrete;
                    _coletaModel.dataColeta = this.dataColeta;
                    _coletaModel.status = this.status;
                    _coletaModel.motivoFalha = this.motivoFalha;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            viewToColetaModel();

            try
            {
                _coletaRepository.editar(_coletaModel);
                MessageBox.Show($"#{_coletaModel.id} - Coleta alterada com sucesso.", this.Text.ToString(), MessageBoxButtons.OK);
                IEmail email = new EmailController();
                switch (_coletaModel.status)
                {
                    case "concluído":
                        email.enviarEmailColetaConcluida(_coletaModel);
                        break;
                    case "finalizada - sem coleta":
                        email.enviarEmailColetaFalhou(_coletaModel);
                        break;
                    default:
                        break;
                }

                
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}

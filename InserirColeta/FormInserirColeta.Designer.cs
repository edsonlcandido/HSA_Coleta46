using System.Windows.Forms;

namespace InserirColeta
{
    partial class FormInserirColeta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInserirColeta));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelSolicitante = new System.Windows.Forms.Label();
            this.labelSetor = new System.Windows.Forms.Label();
            this.textBoxSolicitante = new System.Windows.Forms.TextBox();
            this.textBoxSetor = new System.Windows.Forms.TextBox();
            this.textBox_CC_Projeto = new System.Windows.Forms.TextBox();
            this.label_CC_Projeto = new System.Windows.Forms.Label();
            this.labelDataNecessesaria = new System.Windows.Forms.Label();
            this.dateTimePickerDataNecessesaria = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPeriodo = new System.Windows.Forms.ComboBox();
            this.labelPeriodo = new System.Windows.Forms.Label();
            this.groupBoxEnderecos = new System.Windows.Forms.GroupBox();
            this.textBoxEnderecoEntrega = new System.Windows.Forms.TextBox();
            this.labelEndereçoEntrega = new System.Windows.Forms.Label();
            this.textBoxEnderecoColeta = new System.Windows.Forms.TextBox();
            this.labelEnderecoColeta = new System.Windows.Forms.Label();
            this.textBoxLocalEntrega = new System.Windows.Forms.TextBox();
            this.labelLocalEntrega = new System.Windows.Forms.Label();
            this.textBoxLocalColeta = new System.Windows.Forms.TextBox();
            this.labelLocalColeta = new System.Windows.Forms.Label();
            this.groupBoxMaterial = new System.Windows.Forms.GroupBox();
            this.textBoxQuantidadeVolume = new System.Windows.Forms.TextBox();
            this.labelQuantidadeVolumes = new System.Windows.Forms.Label();
            this.textBoxMaterialPeso = new System.Windows.Forms.TextBox();
            this.labelMaterialPeso = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxMaterialDimensoes = new System.Windows.Forms.TextBox();
            this.labelMaterialDimensoes = new System.Windows.Forms.Label();
            this.textBoxMaterialDescricao = new System.Windows.Forms.TextBox();
            this.labelMaterialDescricao = new System.Windows.Forms.Label();
            this.textBoxNotaFiscal = new System.Windows.Forms.TextBox();
            this.labelNotaFiscal = new System.Windows.Forms.Label();
            this.textBoxValorNotaFiscal = new System.Windows.Forms.TextBox();
            this.labelValorNotaFiscal = new System.Windows.Forms.Label();
            this.labelObs = new System.Windows.Forms.Label();
            this.textBoxObs = new System.Windows.Forms.TextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.labelDataInclusão = new System.Windows.Forms.Label();
            this.textBoxDataInclusao = new System.Windows.Forms.TextBox();
            this.buttonFechar = new System.Windows.Forms.Button();
            this.buttonIncluir = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.textBoxTransportadora = new System.Windows.Forms.TextBox();
            this.labelTransportadora = new System.Windows.Forms.Label();
            this.labelValorFrete = new System.Windows.Forms.Label();
            this.textBoxValorFrete = new System.Windows.Forms.TextBox();
            this.dateTimePickerDataColeta = new System.Windows.Forms.DateTimePicker();
            this.labelDataColeta = new System.Windows.Forms.Label();
            this.textBoxMotivoFalha = new System.Windows.Forms.TextBox();
            this.labelMotivoFalha = new System.Windows.Forms.Label();
            this.labelCamposObrigatorios = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label_CC_Projeto_Alert = new System.Windows.Forms.Label();
            this.labelMaterialPeso_Alert = new System.Windows.Forms.Label();
            this.labellabelQuantidadeVolumes_Alert = new System.Windows.Forms.Label();
            this.labelValorNotaFiscal_Alert = new System.Windows.Forms.Label();
            this.groupBoxEnderecos.SuspendLayout();
            this.groupBoxMaterial.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(12, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(122, 40);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "{Titulo}";
            // 
            // labelSolicitante
            // 
            this.labelSolicitante.AutoSize = true;
            this.labelSolicitante.Location = new System.Drawing.Point(12, 83);
            this.labelSolicitante.Name = "labelSolicitante";
            this.labelSolicitante.Size = new System.Drawing.Size(122, 17);
            this.labelSolicitante.TabIndex = 1;
            this.labelSolicitante.Text = "Solicitante [email]";
            // 
            // labelSetor
            // 
            this.labelSetor.AutoSize = true;
            this.labelSetor.Location = new System.Drawing.Point(12, 114);
            this.labelSetor.Name = "labelSetor";
            this.labelSetor.Size = new System.Drawing.Size(43, 17);
            this.labelSetor.TabIndex = 2;
            this.labelSetor.Text = "Setor";
            // 
            // textBoxSolicitante
            // 
            this.textBoxSolicitante.Location = new System.Drawing.Point(177, 79);
            this.textBoxSolicitante.Name = "textBoxSolicitante";
            this.textBoxSolicitante.Size = new System.Drawing.Size(360, 25);
            this.textBoxSolicitante.TabIndex = 0;
            // 
            // textBoxSetor
            // 
            this.textBoxSetor.Location = new System.Drawing.Point(177, 110);
            this.textBoxSetor.Name = "textBoxSetor";
            this.textBoxSetor.Size = new System.Drawing.Size(120, 25);
            this.textBoxSetor.TabIndex = 1;
            // 
            // textBox_CC_Projeto
            // 
            this.textBox_CC_Projeto.Location = new System.Drawing.Point(177, 141);
            this.textBox_CC_Projeto.Name = "textBox_CC_Projeto";
            this.textBox_CC_Projeto.Size = new System.Drawing.Size(360, 25);
            this.textBox_CC_Projeto.TabIndex = 2;
            this.textBox_CC_Projeto.Enter += new System.EventHandler(this.textBox_CC_Projeto_Enter);
            this.textBox_CC_Projeto.Leave += new System.EventHandler(this.textBox_CC_Projeto_Leave);
            // 
            // label_CC_Projeto
            // 
            this.label_CC_Projeto.AutoSize = true;
            this.label_CC_Projeto.Location = new System.Drawing.Point(12, 145);
            this.label_CC_Projeto.Name = "label_CC_Projeto";
            this.label_CC_Projeto.Size = new System.Drawing.Size(88, 17);
            this.label_CC_Projeto.TabIndex = 5;
            this.label_CC_Projeto.Text = "CC / Projeto";
            // 
            // labelDataNecessesaria
            // 
            this.labelDataNecessesaria.AutoSize = true;
            this.labelDataNecessesaria.Location = new System.Drawing.Point(12, 176);
            this.labelDataNecessesaria.Name = "labelDataNecessesaria";
            this.labelDataNecessesaria.Size = new System.Drawing.Size(159, 17);
            this.labelDataNecessesaria.TabIndex = 7;
            this.labelDataNecessesaria.Text = "Necessidade da Coleta";
            // 
            // dateTimePickerDataNecessesaria
            // 
            this.dateTimePickerDataNecessesaria.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePickerDataNecessesaria.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDataNecessesaria.Location = new System.Drawing.Point(177, 172);
            this.dateTimePickerDataNecessesaria.MinDate = new System.DateTime(2022, 10, 7, 0, 0, 0, 0);
            this.dateTimePickerDataNecessesaria.Name = "dateTimePickerDataNecessesaria";
            this.dateTimePickerDataNecessesaria.Size = new System.Drawing.Size(120, 25);
            this.dateTimePickerDataNecessesaria.TabIndex = 3;
            this.dateTimePickerDataNecessesaria.Value = new System.DateTime(2022, 10, 7, 0, 0, 0, 0);
            // 
            // comboBoxPeriodo
            // 
            this.comboBoxPeriodo.FormattingEnabled = true;
            this.comboBoxPeriodo.Items.AddRange(new object[] {
            "manhã",
            "tarde",
            "noite"});
            this.comboBoxPeriodo.Location = new System.Drawing.Point(416, 172);
            this.comboBoxPeriodo.Name = "comboBoxPeriodo";
            this.comboBoxPeriodo.Size = new System.Drawing.Size(120, 25);
            this.comboBoxPeriodo.TabIndex = 4;
            this.comboBoxPeriodo.Text = "manhã";
            // 
            // labelPeriodo
            // 
            this.labelPeriodo.AutoSize = true;
            this.labelPeriodo.Location = new System.Drawing.Point(346, 176);
            this.labelPeriodo.Name = "labelPeriodo";
            this.labelPeriodo.Size = new System.Drawing.Size(58, 17);
            this.labelPeriodo.TabIndex = 4;
            this.labelPeriodo.Text = "Periodo";
            // 
            // groupBoxEnderecos
            // 
            this.groupBoxEnderecos.Controls.Add(this.textBoxEnderecoEntrega);
            this.groupBoxEnderecos.Controls.Add(this.labelEndereçoEntrega);
            this.groupBoxEnderecos.Controls.Add(this.textBoxEnderecoColeta);
            this.groupBoxEnderecos.Controls.Add(this.labelEnderecoColeta);
            this.groupBoxEnderecos.Controls.Add(this.textBoxLocalEntrega);
            this.groupBoxEnderecos.Controls.Add(this.labelLocalEntrega);
            this.groupBoxEnderecos.Controls.Add(this.textBoxLocalColeta);
            this.groupBoxEnderecos.Controls.Add(this.labelLocalColeta);
            this.groupBoxEnderecos.Font = new System.Drawing.Font("Arial", 14.25F);
            this.groupBoxEnderecos.Location = new System.Drawing.Point(12, 203);
            this.groupBoxEnderecos.Name = "groupBoxEnderecos";
            this.groupBoxEnderecos.Size = new System.Drawing.Size(1062, 152);
            this.groupBoxEnderecos.TabIndex = 5;
            this.groupBoxEnderecos.TabStop = false;
            this.groupBoxEnderecos.Text = "Endereços";
            // 
            // textBoxEnderecoEntrega
            // 
            this.textBoxEnderecoEntrega.Font = new System.Drawing.Font("Arial", 11.25F);
            this.textBoxEnderecoEntrega.Location = new System.Drawing.Point(690, 59);
            this.textBoxEnderecoEntrega.Multiline = true;
            this.textBoxEnderecoEntrega.Name = "textBoxEnderecoEntrega";
            this.textBoxEnderecoEntrega.Size = new System.Drawing.Size(360, 80);
            this.textBoxEnderecoEntrega.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBoxEnderecoEntrega, "Endereço da entrega:\r\nex. \r\nAvenida Osvaldo Berto, 475\r\nDistr. Industrial Alfredo" +
        " Rela\r\n13255-405 - Itatiba-SP -Brasil\r\n");
            // 
            // labelEndereçoEntrega
            // 
            this.labelEndereçoEntrega.AutoSize = true;
            this.labelEndereçoEntrega.Font = new System.Drawing.Font("Arial", 11.25F);
            this.labelEndereçoEntrega.Location = new System.Drawing.Point(537, 59);
            this.labelEndereçoEntrega.Name = "labelEndereçoEntrega";
            this.labelEndereçoEntrega.Size = new System.Drawing.Size(144, 17);
            this.labelEndereçoEntrega.TabIndex = 19;
            this.labelEndereçoEntrega.Text = "Endereço de entrega";
            // 
            // textBoxEnderecoColeta
            // 
            this.textBoxEnderecoColeta.Font = new System.Drawing.Font("Arial", 11.25F);
            this.textBoxEnderecoColeta.Location = new System.Drawing.Point(165, 59);
            this.textBoxEnderecoColeta.Multiline = true;
            this.textBoxEnderecoColeta.Name = "textBoxEnderecoColeta";
            this.textBoxEnderecoColeta.Size = new System.Drawing.Size(360, 80);
            this.textBoxEnderecoColeta.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBoxEnderecoColeta, "Endereço da coleta:\r\nex. \r\nAvenida Osvaldo Berto, 475\r\nDistr. Industrial Alfredo " +
        "Rela\r\n13255-405 - Itatiba-SP -Brasil");
            // 
            // labelEnderecoColeta
            // 
            this.labelEnderecoColeta.AutoSize = true;
            this.labelEnderecoColeta.Font = new System.Drawing.Font("Arial", 11.25F);
            this.labelEnderecoColeta.Location = new System.Drawing.Point(6, 59);
            this.labelEnderecoColeta.Name = "labelEnderecoColeta";
            this.labelEnderecoColeta.Size = new System.Drawing.Size(134, 17);
            this.labelEnderecoColeta.TabIndex = 5;
            this.labelEnderecoColeta.Text = "Endereço de coleta";
            // 
            // textBoxLocalEntrega
            // 
            this.textBoxLocalEntrega.Font = new System.Drawing.Font("Arial", 11.25F);
            this.textBoxLocalEntrega.Location = new System.Drawing.Point(690, 28);
            this.textBoxLocalEntrega.Name = "textBoxLocalEntrega";
            this.textBoxLocalEntrega.Size = new System.Drawing.Size(360, 25);
            this.textBoxLocalEntrega.TabIndex = 2;
            // 
            // labelLocalEntrega
            // 
            this.labelLocalEntrega.AutoSize = true;
            this.labelLocalEntrega.Font = new System.Drawing.Font("Arial", 11.25F);
            this.labelLocalEntrega.Location = new System.Drawing.Point(585, 32);
            this.labelLocalEntrega.Name = "labelLocalEntrega";
            this.labelLocalEntrega.Size = new System.Drawing.Size(96, 17);
            this.labelLocalEntrega.TabIndex = 15;
            this.labelLocalEntrega.Text = "Local entrega";
            // 
            // textBoxLocalColeta
            // 
            this.textBoxLocalColeta.Font = new System.Drawing.Font("Arial", 11.25F);
            this.textBoxLocalColeta.Location = new System.Drawing.Point(165, 28);
            this.textBoxLocalColeta.Name = "textBoxLocalColeta";
            this.textBoxLocalColeta.Size = new System.Drawing.Size(360, 25);
            this.textBoxLocalColeta.TabIndex = 0;
            // 
            // labelLocalColeta
            // 
            this.labelLocalColeta.AutoSize = true;
            this.labelLocalColeta.Font = new System.Drawing.Font("Arial", 11.25F);
            this.labelLocalColeta.Location = new System.Drawing.Point(6, 32);
            this.labelLocalColeta.Name = "labelLocalColeta";
            this.labelLocalColeta.Size = new System.Drawing.Size(106, 17);
            this.labelLocalColeta.TabIndex = 13;
            this.labelLocalColeta.Text = "Local da coleta";
            // 
            // groupBoxMaterial
            // 
            this.groupBoxMaterial.Controls.Add(this.labellabelQuantidadeVolumes_Alert);
            this.groupBoxMaterial.Controls.Add(this.labelMaterialPeso_Alert);
            this.groupBoxMaterial.Controls.Add(this.textBoxQuantidadeVolume);
            this.groupBoxMaterial.Controls.Add(this.labelQuantidadeVolumes);
            this.groupBoxMaterial.Controls.Add(this.textBoxMaterialPeso);
            this.groupBoxMaterial.Controls.Add(this.labelMaterialPeso);
            this.groupBoxMaterial.Controls.Add(this.label11);
            this.groupBoxMaterial.Controls.Add(this.textBoxMaterialDimensoes);
            this.groupBoxMaterial.Controls.Add(this.labelMaterialDimensoes);
            this.groupBoxMaterial.Controls.Add(this.textBoxMaterialDescricao);
            this.groupBoxMaterial.Controls.Add(this.labelMaterialDescricao);
            this.groupBoxMaterial.Font = new System.Drawing.Font("Arial", 14.25F);
            this.groupBoxMaterial.Location = new System.Drawing.Point(12, 361);
            this.groupBoxMaterial.Name = "groupBoxMaterial";
            this.groupBoxMaterial.Size = new System.Drawing.Size(1062, 184);
            this.groupBoxMaterial.TabIndex = 6;
            this.groupBoxMaterial.TabStop = false;
            this.groupBoxMaterial.Text = "Material";
            // 
            // textBoxQuantidadeVolume
            // 
            this.textBoxQuantidadeVolume.Font = new System.Drawing.Font("Arial", 11.25F);
            this.textBoxQuantidadeVolume.Location = new System.Drawing.Point(165, 148);
            this.textBoxQuantidadeVolume.Name = "textBoxQuantidadeVolume";
            this.textBoxQuantidadeVolume.Size = new System.Drawing.Size(120, 25);
            this.textBoxQuantidadeVolume.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBoxQuantidadeVolume, "Somente numeros inteiros\r\nex. 1");
            this.textBoxQuantidadeVolume.Enter += new System.EventHandler(this.textBoxQuantidadeVolume_Enter);
            this.textBoxQuantidadeVolume.Leave += new System.EventHandler(this.textBoxQuantidadeVolume_Leave);
            // 
            // labelQuantidadeVolumes
            // 
            this.labelQuantidadeVolumes.AutoSize = true;
            this.labelQuantidadeVolumes.Font = new System.Drawing.Font("Arial", 11.25F);
            this.labelQuantidadeVolumes.Location = new System.Drawing.Point(6, 154);
            this.labelQuantidadeVolumes.Name = "labelQuantidadeVolumes";
            this.labelQuantidadeVolumes.Size = new System.Drawing.Size(142, 17);
            this.labelQuantidadeVolumes.TabIndex = 33;
            this.labelQuantidadeVolumes.Text = "Quantidade volumes";
            // 
            // textBoxMaterialPeso
            // 
            this.textBoxMaterialPeso.Font = new System.Drawing.Font("Arial", 11.25F);
            this.textBoxMaterialPeso.Location = new System.Drawing.Point(165, 117);
            this.textBoxMaterialPeso.Name = "textBoxMaterialPeso";
            this.textBoxMaterialPeso.Size = new System.Drawing.Size(120, 25);
            this.textBoxMaterialPeso.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBoxMaterialPeso, "Somente numeros\r\nex.\r\n15,5");
            this.textBoxMaterialPeso.Enter += new System.EventHandler(this.textBoxMaterialPeso_Enter);
            this.textBoxMaterialPeso.Leave += new System.EventHandler(this.textBoxMaterialPeso_Leave);
            // 
            // labelMaterialPeso
            // 
            this.labelMaterialPeso.AutoSize = true;
            this.labelMaterialPeso.Font = new System.Drawing.Font("Arial", 11.25F);
            this.labelMaterialPeso.Location = new System.Drawing.Point(6, 123);
            this.labelMaterialPeso.Name = "labelMaterialPeso";
            this.labelMaterialPeso.Size = new System.Drawing.Size(69, 17);
            this.labelMaterialPeso.TabIndex = 31;
            this.labelMaterialPeso.Text = "Peso [kg]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 11.25F);
            this.label11.Location = new System.Drawing.Point(192, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "C x L x A";
            // 
            // textBoxMaterialDimensoes
            // 
            this.textBoxMaterialDimensoes.Font = new System.Drawing.Font("Arial", 11.25F);
            this.textBoxMaterialDimensoes.Location = new System.Drawing.Point(165, 86);
            this.textBoxMaterialDimensoes.Name = "textBoxMaterialDimensoes";
            this.textBoxMaterialDimensoes.Size = new System.Drawing.Size(119, 25);
            this.textBoxMaterialDimensoes.TabIndex = 1;
            this.toolTip1.SetToolTip(this.textBoxMaterialDimensoes, "ex.\r\n1000x1000x1000");
            // 
            // labelMaterialDimensoes
            // 
            this.labelMaterialDimensoes.AutoSize = true;
            this.labelMaterialDimensoes.Font = new System.Drawing.Font("Arial", 11.25F);
            this.labelMaterialDimensoes.Location = new System.Drawing.Point(6, 92);
            this.labelMaterialDimensoes.Name = "labelMaterialDimensoes";
            this.labelMaterialDimensoes.Size = new System.Drawing.Size(121, 17);
            this.labelMaterialDimensoes.TabIndex = 22;
            this.labelMaterialDimensoes.Text = "Dimensões [mm]";
            // 
            // textBoxMaterialDescricao
            // 
            this.textBoxMaterialDescricao.Font = new System.Drawing.Font("Arial", 11.25F);
            this.textBoxMaterialDescricao.Location = new System.Drawing.Point(165, 28);
            this.textBoxMaterialDescricao.Name = "textBoxMaterialDescricao";
            this.textBoxMaterialDescricao.Size = new System.Drawing.Size(885, 25);
            this.textBoxMaterialDescricao.TabIndex = 0;
            // 
            // labelMaterialDescricao
            // 
            this.labelMaterialDescricao.AutoSize = true;
            this.labelMaterialDescricao.Font = new System.Drawing.Font("Arial", 11.25F);
            this.labelMaterialDescricao.Location = new System.Drawing.Point(6, 31);
            this.labelMaterialDescricao.Name = "labelMaterialDescricao";
            this.labelMaterialDescricao.Size = new System.Drawing.Size(75, 17);
            this.labelMaterialDescricao.TabIndex = 13;
            this.labelMaterialDescricao.Text = "Descrição";
            // 
            // textBoxNotaFiscal
            // 
            this.textBoxNotaFiscal.Location = new System.Drawing.Point(176, 551);
            this.textBoxNotaFiscal.Name = "textBoxNotaFiscal";
            this.textBoxNotaFiscal.Size = new System.Drawing.Size(120, 25);
            this.textBoxNotaFiscal.TabIndex = 7;
            this.toolTip1.SetToolTip(this.textBoxNotaFiscal, "ex.\r\nNF123.456");
            // 
            // labelNotaFiscal
            // 
            this.labelNotaFiscal.AutoSize = true;
            this.labelNotaFiscal.Location = new System.Drawing.Point(11, 555);
            this.labelNotaFiscal.Name = "labelNotaFiscal";
            this.labelNotaFiscal.Size = new System.Drawing.Size(103, 17);
            this.labelNotaFiscal.TabIndex = 22;
            this.labelNotaFiscal.Text = "Numero da NF";
            // 
            // textBoxValorNotaFiscal
            // 
            this.textBoxValorNotaFiscal.Location = new System.Drawing.Point(176, 582);
            this.textBoxValorNotaFiscal.Name = "textBoxValorNotaFiscal";
            this.textBoxValorNotaFiscal.Size = new System.Drawing.Size(120, 25);
            this.textBoxValorNotaFiscal.TabIndex = 8;
            this.toolTip1.SetToolTip(this.textBoxValorNotaFiscal, "Somente numeros\r\nex.\r\n150,00");
            this.textBoxValorNotaFiscal.Enter += new System.EventHandler(this.textBoxValorNotaFiscal_Enter);
            this.textBoxValorNotaFiscal.Leave += new System.EventHandler(this.textBoxValorNotaFiscal_Leave);
            // 
            // labelValorNotaFiscal
            // 
            this.labelValorNotaFiscal.AutoSize = true;
            this.labelValorNotaFiscal.Location = new System.Drawing.Point(11, 586);
            this.labelValorNotaFiscal.Name = "labelValorNotaFiscal";
            this.labelValorNotaFiscal.Size = new System.Drawing.Size(94, 17);
            this.labelValorNotaFiscal.TabIndex = 24;
            this.labelValorNotaFiscal.Text = "Valor NF [R$]";
            // 
            // labelObs
            // 
            this.labelObs.AutoSize = true;
            this.labelObs.Location = new System.Drawing.Point(11, 617);
            this.labelObs.Name = "labelObs";
            this.labelObs.Size = new System.Drawing.Size(40, 17);
            this.labelObs.TabIndex = 26;
            this.labelObs.Text = "Obs.";
            // 
            // textBoxObs
            // 
            this.textBoxObs.Font = new System.Drawing.Font("Arial", 11.25F);
            this.textBoxObs.Location = new System.Drawing.Point(176, 617);
            this.textBoxObs.Multiline = true;
            this.textBoxObs.Name = "textBoxObs";
            this.textBoxObs.Size = new System.Drawing.Size(360, 80);
            this.textBoxObs.TabIndex = 9;
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(702, 79);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(120, 25);
            this.textBoxId.TabIndex = 27;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(591, 83);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(105, 17);
            this.labelId.TabIndex = 28;
            this.labelId.Text = "No. Solicitação";
            // 
            // labelDataInclusão
            // 
            this.labelDataInclusão.AutoSize = true;
            this.labelDataInclusão.Location = new System.Drawing.Point(897, 83);
            this.labelDataInclusão.Name = "labelDataInclusão";
            this.labelDataInclusão.Size = new System.Drawing.Size(39, 17);
            this.labelDataInclusão.TabIndex = 30;
            this.labelDataInclusão.Text = "Data";
            // 
            // textBoxDataInclusao
            // 
            this.textBoxDataInclusao.Enabled = false;
            this.textBoxDataInclusao.Location = new System.Drawing.Point(942, 79);
            this.textBoxDataInclusao.Name = "textBoxDataInclusao";
            this.textBoxDataInclusao.Size = new System.Drawing.Size(120, 25);
            this.textBoxDataInclusao.TabIndex = 29;
            // 
            // buttonFechar
            // 
            this.buttonFechar.Location = new System.Drawing.Point(982, 714);
            this.buttonFechar.Name = "buttonFechar";
            this.buttonFechar.Size = new System.Drawing.Size(90, 30);
            this.buttonFechar.TabIndex = 17;
            this.buttonFechar.Text = "Fechar";
            this.buttonFechar.UseVisualStyleBackColor = true;
            this.buttonFechar.Click += new System.EventHandler(this.buttonFechar_Click);
            // 
            // buttonIncluir
            // 
            this.buttonIncluir.Location = new System.Drawing.Point(886, 714);
            this.buttonIncluir.Name = "buttonIncluir";
            this.buttonIncluir.Size = new System.Drawing.Size(90, 30);
            this.buttonIncluir.TabIndex = 16;
            this.buttonIncluir.Text = "Incluir";
            this.buttonIncluir.UseVisualStyleBackColor = true;
            this.buttonIncluir.Click += new System.EventHandler(this.buttonIncluir_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(790, 714);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(90, 30);
            this.buttonSalvar.TabIndex = 15;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(886, 645);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(50, 17);
            this.labelStatus.TabIndex = 35;
            this.labelStatus.Text = "Status";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "aguardando",
            "em andamento",
            "concluído",
            "finalizada - sem coleta"});
            this.comboBoxStatus.Location = new System.Drawing.Point(942, 641);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(120, 25);
            this.comboBoxStatus.TabIndex = 13;
            this.comboBoxStatus.Text = "aguardando";
            // 
            // textBoxTransportadora
            // 
            this.textBoxTransportadora.Font = new System.Drawing.Font("Arial", 11.25F);
            this.textBoxTransportadora.Location = new System.Drawing.Point(702, 579);
            this.textBoxTransportadora.Name = "textBoxTransportadora";
            this.textBoxTransportadora.Size = new System.Drawing.Size(360, 25);
            this.textBoxTransportadora.TabIndex = 10;
            // 
            // labelTransportadora
            // 
            this.labelTransportadora.AutoSize = true;
            this.labelTransportadora.Font = new System.Drawing.Font("Arial", 11.25F);
            this.labelTransportadora.Location = new System.Drawing.Point(589, 582);
            this.labelTransportadora.Name = "labelTransportadora";
            this.labelTransportadora.Size = new System.Drawing.Size(107, 17);
            this.labelTransportadora.TabIndex = 21;
            this.labelTransportadora.Text = "Transportadora";
            // 
            // labelValorFrete
            // 
            this.labelValorFrete.AutoSize = true;
            this.labelValorFrete.Location = new System.Drawing.Point(572, 614);
            this.labelValorFrete.Name = "labelValorFrete";
            this.labelValorFrete.Size = new System.Drawing.Size(124, 17);
            this.labelValorFrete.TabIndex = 37;
            this.labelValorFrete.Text = "Valor do frete [R$]";
            // 
            // textBoxValorFrete
            // 
            this.textBoxValorFrete.Location = new System.Drawing.Point(702, 610);
            this.textBoxValorFrete.Name = "textBoxValorFrete";
            this.textBoxValorFrete.Size = new System.Drawing.Size(120, 25);
            this.textBoxValorFrete.TabIndex = 11;
            // 
            // dateTimePickerDataColeta
            // 
            this.dateTimePickerDataColeta.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePickerDataColeta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDataColeta.Location = new System.Drawing.Point(702, 641);
            this.dateTimePickerDataColeta.Name = "dateTimePickerDataColeta";
            this.dateTimePickerDataColeta.Size = new System.Drawing.Size(120, 25);
            this.dateTimePickerDataColeta.TabIndex = 12;
            this.dateTimePickerDataColeta.Value = new System.DateTime(2022, 10, 7, 0, 0, 0, 0);
            // 
            // labelDataColeta
            // 
            this.labelDataColeta.AutoSize = true;
            this.labelDataColeta.Location = new System.Drawing.Point(591, 645);
            this.labelDataColeta.Name = "labelDataColeta";
            this.labelDataColeta.Size = new System.Drawing.Size(105, 17);
            this.labelDataColeta.TabIndex = 38;
            this.labelDataColeta.Text = "Data da Coleta";
            // 
            // textBoxMotivoFalha
            // 
            this.textBoxMotivoFalha.Font = new System.Drawing.Font("Arial", 11.25F);
            this.textBoxMotivoFalha.Location = new System.Drawing.Point(702, 672);
            this.textBoxMotivoFalha.Name = "textBoxMotivoFalha";
            this.textBoxMotivoFalha.Size = new System.Drawing.Size(360, 25);
            this.textBoxMotivoFalha.TabIndex = 14;
            // 
            // labelMotivoFalha
            // 
            this.labelMotivoFalha.AutoSize = true;
            this.labelMotivoFalha.Font = new System.Drawing.Font("Arial", 11.25F);
            this.labelMotivoFalha.Location = new System.Drawing.Point(612, 676);
            this.labelMotivoFalha.Name = "labelMotivoFalha";
            this.labelMotivoFalha.Size = new System.Drawing.Size(84, 17);
            this.labelMotivoFalha.TabIndex = 40;
            this.labelMotivoFalha.Text = "Motivo falha";
            // 
            // labelCamposObrigatorios
            // 
            this.labelCamposObrigatorios.AutoSize = true;
            this.labelCamposObrigatorios.BackColor = System.Drawing.SystemColors.Info;
            this.labelCamposObrigatorios.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCamposObrigatorios.ForeColor = System.Drawing.Color.Red;
            this.labelCamposObrigatorios.Location = new System.Drawing.Point(12, 55);
            this.labelCamposObrigatorios.Name = "labelCamposObrigatorios";
            this.labelCamposObrigatorios.Size = new System.Drawing.Size(324, 15);
            this.labelCamposObrigatorios.TabIndex = 41;
            this.labelCamposObrigatorios.Text = "Todos campos marcados com (*) devem ser preenchidos";
            this.labelCamposObrigatorios.Visible = false;
            // 
            // toolTip1
            // 
            this.toolTip1.Active = false;
            // 
            // label_CC_Projeto_Alert
            // 
            this.label_CC_Projeto_Alert.AutoSize = true;
            this.label_CC_Projeto_Alert.BackColor = System.Drawing.SystemColors.Info;
            this.label_CC_Projeto_Alert.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CC_Projeto_Alert.ForeColor = System.Drawing.Color.Red;
            this.label_CC_Projeto_Alert.Location = new System.Drawing.Point(543, 138);
            this.label_CC_Projeto_Alert.Name = "label_CC_Projeto_Alert";
            this.label_CC_Projeto_Alert.Size = new System.Drawing.Size(278, 30);
            this.label_CC_Projeto_Alert.TabIndex = 42;
            this.label_CC_Projeto_Alert.Text = "Não usar somente números.\r\nPreencher conf. ex. CC4000 ou NB0101 /  AF2820";
            this.label_CC_Projeto_Alert.Visible = false;
            // 
            // labelMaterialPeso_Alert
            // 
            this.labelMaterialPeso_Alert.AutoSize = true;
            this.labelMaterialPeso_Alert.BackColor = System.Drawing.SystemColors.Info;
            this.labelMaterialPeso_Alert.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaterialPeso_Alert.ForeColor = System.Drawing.Color.Red;
            this.labelMaterialPeso_Alert.Location = new System.Drawing.Point(294, 114);
            this.labelMaterialPeso_Alert.Name = "labelMaterialPeso_Alert";
            this.labelMaterialPeso_Alert.Size = new System.Drawing.Size(113, 30);
            this.labelMaterialPeso_Alert.TabIndex = 43;
            this.labelMaterialPeso_Alert.Text = "Somente números.\r\nEx. 15,5";
            this.labelMaterialPeso_Alert.Visible = false;
            // 
            // labellabelQuantidadeVolumes_Alert
            // 
            this.labellabelQuantidadeVolumes_Alert.AutoSize = true;
            this.labellabelQuantidadeVolumes_Alert.BackColor = System.Drawing.SystemColors.Info;
            this.labellabelQuantidadeVolumes_Alert.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellabelQuantidadeVolumes_Alert.ForeColor = System.Drawing.Color.Red;
            this.labellabelQuantidadeVolumes_Alert.Location = new System.Drawing.Point(294, 145);
            this.labellabelQuantidadeVolumes_Alert.Name = "labellabelQuantidadeVolumes_Alert";
            this.labellabelQuantidadeVolumes_Alert.Size = new System.Drawing.Size(154, 30);
            this.labellabelQuantidadeVolumes_Alert.TabIndex = 44;
            this.labellabelQuantidadeVolumes_Alert.Text = "Somente numeros inteiros\r\nex. 1";
            this.labellabelQuantidadeVolumes_Alert.Visible = false;
            this.labellabelQuantidadeVolumes_Alert.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelValorNotaFiscal_Alert
            // 
            this.labelValorNotaFiscal_Alert.AutoSize = true;
            this.labelValorNotaFiscal_Alert.BackColor = System.Drawing.SystemColors.Info;
            this.labelValorNotaFiscal_Alert.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValorNotaFiscal_Alert.ForeColor = System.Drawing.Color.Red;
            this.labelValorNotaFiscal_Alert.Location = new System.Drawing.Point(310, 579);
            this.labelValorNotaFiscal_Alert.Name = "labelValorNotaFiscal_Alert";
            this.labelValorNotaFiscal_Alert.Size = new System.Drawing.Size(169, 30);
            this.labelValorNotaFiscal_Alert.TabIndex = 45;
            this.labelValorNotaFiscal_Alert.Text = "Evite usar somente números.\r\nEx. NF123.456";
            this.labelValorNotaFiscal_Alert.Visible = false;
            // 
            // FormInserirColeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 756);
            this.Controls.Add(this.labelValorNotaFiscal_Alert);
            this.Controls.Add(this.label_CC_Projeto_Alert);
            this.Controls.Add(this.labelCamposObrigatorios);
            this.Controls.Add(this.textBoxMotivoFalha);
            this.Controls.Add(this.labelMotivoFalha);
            this.Controls.Add(this.dateTimePickerDataColeta);
            this.Controls.Add(this.labelDataColeta);
            this.Controls.Add(this.labelValorFrete);
            this.Controls.Add(this.textBoxValorFrete);
            this.Controls.Add(this.textBoxTransportadora);
            this.Controls.Add(this.labelTransportadora);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonIncluir);
            this.Controls.Add(this.buttonFechar);
            this.Controls.Add(this.labelDataInclusão);
            this.Controls.Add(this.textBoxDataInclusao);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.textBoxObs);
            this.Controls.Add(this.labelObs);
            this.Controls.Add(this.textBoxValorNotaFiscal);
            this.Controls.Add(this.labelValorNotaFiscal);
            this.Controls.Add(this.textBoxNotaFiscal);
            this.Controls.Add(this.labelNotaFiscal);
            this.Controls.Add(this.groupBoxMaterial);
            this.Controls.Add(this.groupBoxEnderecos);
            this.Controls.Add(this.labelPeriodo);
            this.Controls.Add(this.comboBoxPeriodo);
            this.Controls.Add(this.dateTimePickerDataNecessesaria);
            this.Controls.Add(this.labelDataNecessesaria);
            this.Controls.Add(this.textBox_CC_Projeto);
            this.Controls.Add(this.label_CC_Projeto);
            this.Controls.Add(this.textBoxSetor);
            this.Controls.Add(this.textBoxSolicitante);
            this.Controls.Add(this.labelSetor);
            this.Controls.Add(this.labelSolicitante);
            this.Controls.Add(this.labelTitulo);
            this.Font = new System.Drawing.Font("Arial", 11.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormInserirColeta";
            this.Text = "HSA Coleta";
            this.Load += new System.EventHandler(this.FormInserirColeta_Load);
            this.groupBoxEnderecos.ResumeLayout(false);
            this.groupBoxEnderecos.PerformLayout();
            this.groupBoxMaterial.ResumeLayout(false);
            this.groupBoxMaterial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTitulo;
        private Label labelSolicitante;
        private Label labelSetor;
        private TextBox textBoxSolicitante;
        private TextBox textBoxSetor;
        private TextBox textBox_CC_Projeto;
        private Label label_CC_Projeto;
        private Label labelDataNecessesaria;
        private DateTimePicker dateTimePickerDataNecessesaria;
        private ComboBox comboBoxPeriodo;
        private Label labelPeriodo;
        private GroupBox groupBoxEnderecos;
        private TextBox textBoxEnderecoEntrega;
        private Label labelEndereçoEntrega;
        private TextBox textBoxEnderecoColeta;
        private Label labelEnderecoColeta;
        private TextBox textBoxLocalEntrega;
        private Label labelLocalEntrega;
        private TextBox textBoxLocalColeta;
        private Label labelLocalColeta;
        private GroupBox groupBoxMaterial;
        private TextBox textBoxMaterialDescricao;
        private Label labelMaterialDescricao;
        private TextBox textBoxQuantidadeVolume;
        private Label labelQuantidadeVolumes;
        private TextBox textBoxMaterialPeso;
        private Label labelMaterialPeso;
        private Label label11;
        private TextBox textBoxMaterialDimensoes;
        private Label labelMaterialDimensoes;
        private TextBox textBoxNotaFiscal;
        private Label labelNotaFiscal;
        private TextBox textBoxValorNotaFiscal;
        private Label labelValorNotaFiscal;
        private Label labelObs;
        private TextBox textBoxObs;
        private TextBox textBoxId;
        private Label labelId;
        private Label labelDataInclusão;
        private TextBox textBoxDataInclusao;
        private Button buttonFechar;
        private Button buttonIncluir;
        private Button buttonSalvar;
        private Label labelStatus;
        private ComboBox comboBoxStatus;
        private TextBox textBoxTransportadora;
        private Label labelTransportadora;
        private Label labelValorFrete;
        private TextBox textBoxValorFrete;
        private DateTimePicker dateTimePickerDataColeta;
        private Label labelDataColeta;
        private TextBox textBoxMotivoFalha;
        private Label labelMotivoFalha;
        private Label labelCamposObrigatorios;
        private ToolTip toolTip1;
        private Label label_CC_Projeto_Alert;
        private Label labelMaterialPeso_Alert;
        private Label labellabelQuantidadeVolumes_Alert;
        private Label labelValorNotaFiscal_Alert;
    }
}
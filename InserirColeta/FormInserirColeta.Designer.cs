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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInserirColeta));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSolicitante = new System.Windows.Forms.TextBox();
            this.textBoxSetor = new System.Windows.Forms.TextBox();
            this.textBox_CC_Projeto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerDataNecessesaria = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPeriodo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxEnderecos = new System.Windows.Forms.GroupBox();
            this.textBoxEnderecoEntrega = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxEnderecoColeta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxLocalEntrega = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxLocalColeta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxMaterial = new System.Windows.Forms.GroupBox();
            this.textBoxQuantidadeVolume = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxMaterialPeso = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxMaterialDimensoes = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxMaterialDescricao = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxNotaFiscal = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxValorNotaFiscal = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
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
            this.groupBoxEnderecos.SuspendLayout();
            this.groupBoxMaterial.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Location = new System.Drawing.Point(12, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(169, 55);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "{Titulo}";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Solicitante [email]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Setor";
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
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "CC / Projeto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Necessidade da Coleta";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(352, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Periodo";
            // 
            // groupBoxEnderecos
            // 
            this.groupBoxEnderecos.Controls.Add(this.textBoxEnderecoEntrega);
            this.groupBoxEnderecos.Controls.Add(this.label8);
            this.groupBoxEnderecos.Controls.Add(this.textBoxEnderecoColeta);
            this.groupBoxEnderecos.Controls.Add(this.label9);
            this.groupBoxEnderecos.Controls.Add(this.textBoxLocalEntrega);
            this.groupBoxEnderecos.Controls.Add(this.label7);
            this.groupBoxEnderecos.Controls.Add(this.textBoxLocalColeta);
            this.groupBoxEnderecos.Controls.Add(this.label6);
            this.groupBoxEnderecos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxEnderecos.Location = new System.Drawing.Point(12, 203);
            this.groupBoxEnderecos.Name = "groupBoxEnderecos";
            this.groupBoxEnderecos.Size = new System.Drawing.Size(1062, 152);
            this.groupBoxEnderecos.TabIndex = 5;
            this.groupBoxEnderecos.TabStop = false;
            this.groupBoxEnderecos.Text = "Endereços";
            // 
            // textBoxEnderecoEntrega
            // 
            this.textBoxEnderecoEntrega.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEnderecoEntrega.Location = new System.Drawing.Point(690, 59);
            this.textBoxEnderecoEntrega.Multiline = true;
            this.textBoxEnderecoEntrega.Name = "textBoxEnderecoEntrega";
            this.textBoxEnderecoEntrega.Size = new System.Drawing.Size(360, 80);
            this.textBoxEnderecoEntrega.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(540, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Endereço de entrega";
            // 
            // textBoxEnderecoColeta
            // 
            this.textBoxEnderecoColeta.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEnderecoColeta.Location = new System.Drawing.Point(165, 59);
            this.textBoxEnderecoColeta.Multiline = true;
            this.textBoxEnderecoColeta.Name = "textBoxEnderecoColeta";
            this.textBoxEnderecoColeta.Size = new System.Drawing.Size(360, 80);
            this.textBoxEnderecoColeta.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Endereço de coleta";
            // 
            // textBoxLocalEntrega
            // 
            this.textBoxLocalEntrega.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLocalEntrega.Location = new System.Drawing.Point(690, 28);
            this.textBoxLocalEntrega.Name = "textBoxLocalEntrega";
            this.textBoxLocalEntrega.Size = new System.Drawing.Size(360, 25);
            this.textBoxLocalEntrega.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(588, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Local entrega";
            // 
            // textBoxLocalColeta
            // 
            this.textBoxLocalColeta.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLocalColeta.Location = new System.Drawing.Point(165, 28);
            this.textBoxLocalColeta.Name = "textBoxLocalColeta";
            this.textBoxLocalColeta.Size = new System.Drawing.Size(360, 25);
            this.textBoxLocalColeta.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Local da coleta";
            // 
            // groupBoxMaterial
            // 
            this.groupBoxMaterial.Controls.Add(this.textBoxQuantidadeVolume);
            this.groupBoxMaterial.Controls.Add(this.label18);
            this.groupBoxMaterial.Controls.Add(this.textBoxMaterialPeso);
            this.groupBoxMaterial.Controls.Add(this.label17);
            this.groupBoxMaterial.Controls.Add(this.label11);
            this.groupBoxMaterial.Controls.Add(this.textBoxMaterialDimensoes);
            this.groupBoxMaterial.Controls.Add(this.label10);
            this.groupBoxMaterial.Controls.Add(this.textBoxMaterialDescricao);
            this.groupBoxMaterial.Controls.Add(this.label13);
            this.groupBoxMaterial.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBoxMaterial.Location = new System.Drawing.Point(12, 361);
            this.groupBoxMaterial.Name = "groupBoxMaterial";
            this.groupBoxMaterial.Size = new System.Drawing.Size(1062, 184);
            this.groupBoxMaterial.TabIndex = 6;
            this.groupBoxMaterial.TabStop = false;
            this.groupBoxMaterial.Text = "Material";
            // 
            // textBoxQuantidadeVolume
            // 
            this.textBoxQuantidadeVolume.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxQuantidadeVolume.Location = new System.Drawing.Point(165, 148);
            this.textBoxQuantidadeVolume.Name = "textBoxQuantidadeVolume";
            this.textBoxQuantidadeVolume.Size = new System.Drawing.Size(120, 25);
            this.textBoxQuantidadeVolume.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(6, 154);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(142, 17);
            this.label18.TabIndex = 33;
            this.label18.Text = "Quantidade volumes";
            // 
            // textBoxMaterialPeso
            // 
            this.textBoxMaterialPeso.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMaterialPeso.Location = new System.Drawing.Point(165, 117);
            this.textBoxMaterialPeso.Name = "textBoxMaterialPeso";
            this.textBoxMaterialPeso.Size = new System.Drawing.Size(120, 25);
            this.textBoxMaterialPeso.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(6, 123);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 17);
            this.label17.TabIndex = 31;
            this.label17.Text = "Peso [kg]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(192, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "C x L x A";
            // 
            // textBoxMaterialDimensoes
            // 
            this.textBoxMaterialDimensoes.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMaterialDimensoes.Location = new System.Drawing.Point(165, 86);
            this.textBoxMaterialDimensoes.Name = "textBoxMaterialDimensoes";
            this.textBoxMaterialDimensoes.Size = new System.Drawing.Size(119, 25);
            this.textBoxMaterialDimensoes.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(6, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Dimensões [mm]";
            // 
            // textBoxMaterialDescricao
            // 
            this.textBoxMaterialDescricao.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMaterialDescricao.Location = new System.Drawing.Point(165, 28);
            this.textBoxMaterialDescricao.Name = "textBoxMaterialDescricao";
            this.textBoxMaterialDescricao.Size = new System.Drawing.Size(885, 25);
            this.textBoxMaterialDescricao.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(6, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 17);
            this.label13.TabIndex = 13;
            this.label13.Text = "Descrição";
            // 
            // textBoxNotaFiscal
            // 
            this.textBoxNotaFiscal.Location = new System.Drawing.Point(176, 551);
            this.textBoxNotaFiscal.Name = "textBoxNotaFiscal";
            this.textBoxNotaFiscal.Size = new System.Drawing.Size(120, 25);
            this.textBoxNotaFiscal.TabIndex = 7;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(11, 555);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(103, 17);
            this.label19.TabIndex = 22;
            this.label19.Text = "Numero da NF";
            // 
            // textBoxValorNotaFiscal
            // 
            this.textBoxValorNotaFiscal.Location = new System.Drawing.Point(176, 582);
            this.textBoxValorNotaFiscal.Name = "textBoxValorNotaFiscal";
            this.textBoxValorNotaFiscal.Size = new System.Drawing.Size(120, 25);
            this.textBoxValorNotaFiscal.TabIndex = 8;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(11, 586);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(94, 17);
            this.label20.TabIndex = 24;
            this.label20.Text = "Valor NF [R$]";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(11, 617);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(40, 17);
            this.label21.TabIndex = 26;
            this.label21.Text = "Obs.";
            // 
            // textBoxObs
            // 
            this.textBoxObs.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.textBoxTransportadora.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTransportadora.Location = new System.Drawing.Point(702, 579);
            this.textBoxTransportadora.Name = "textBoxTransportadora";
            this.textBoxTransportadora.Size = new System.Drawing.Size(360, 25);
            this.textBoxTransportadora.TabIndex = 10;
            // 
            // labelTransportadora
            // 
            this.labelTransportadora.AutoSize = true;
            this.labelTransportadora.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.textBoxMotivoFalha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMotivoFalha.Location = new System.Drawing.Point(702, 672);
            this.textBoxMotivoFalha.Name = "textBoxMotivoFalha";
            this.textBoxMotivoFalha.Size = new System.Drawing.Size(360, 25);
            this.textBoxMotivoFalha.TabIndex = 14;
            // 
            // labelMotivoFalha
            // 
            this.labelMotivoFalha.AutoSize = true;
            this.labelMotivoFalha.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMotivoFalha.Location = new System.Drawing.Point(612, 676);
            this.labelMotivoFalha.Name = "labelMotivoFalha";
            this.labelMotivoFalha.Size = new System.Drawing.Size(84, 17);
            this.labelMotivoFalha.TabIndex = 40;
            this.labelMotivoFalha.Text = "Motivo falha";
            // 
            // FormInserirColeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 756);
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
            this.Controls.Add(this.label21);
            this.Controls.Add(this.textBoxValorNotaFiscal);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textBoxNotaFiscal);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.groupBoxMaterial);
            this.Controls.Add(this.groupBoxEnderecos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxPeriodo);
            this.Controls.Add(this.dateTimePickerDataNecessesaria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_CC_Projeto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSetor);
            this.Controls.Add(this.textBoxSolicitante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitulo);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
        private Label label1;
        private Label label2;
        private TextBox textBoxSolicitante;
        private TextBox textBoxSetor;
        private TextBox textBox_CC_Projeto;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePickerDataNecessesaria;
        private ComboBox comboBoxPeriodo;
        private Label label5;
        private GroupBox groupBoxEnderecos;
        private TextBox textBoxEnderecoEntrega;
        private Label label8;
        private TextBox textBoxEnderecoColeta;
        private Label label9;
        private TextBox textBoxLocalEntrega;
        private Label label7;
        private TextBox textBoxLocalColeta;
        private Label label6;
        private GroupBox groupBoxMaterial;
        private TextBox textBoxMaterialDescricao;
        private Label label13;
        private TextBox textBoxQuantidadeVolume;
        private Label label18;
        private TextBox textBoxMaterialPeso;
        private Label label17;
        private Label label11;
        private TextBox textBoxMaterialDimensoes;
        private Label label10;
        private TextBox textBoxNotaFiscal;
        private Label label19;
        private TextBox textBoxValorNotaFiscal;
        private Label label20;
        private Label label21;
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
    }
}
using System.Windows.Forms;
using System;

namespace HSA_Coleta
{
    partial class FormAdministrarColeta
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdministrarColeta));
            this.dataGridViewListarColetas = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarParaOExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.buttonIncluirColeta = new System.Windows.Forms.Button();
            this.buttonEditarColeta = new System.Windows.Forms.Button();
            this.buttonVisualizarColeta = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonListarTodasColetas = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.coletaModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.solicitanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCProjetoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNecessariaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodoColetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localColetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localEntregaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDescricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialDimensoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialPesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeVolumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.obsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notaFiscalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorNotaFiscalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListarColetas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coletaModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListarColetas
            // 
            this.dataGridViewListarColetas.AllowUserToAddRows = false;
            this.dataGridViewListarColetas.AllowUserToDeleteRows = false;
            this.dataGridViewListarColetas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewListarColetas.AutoGenerateColumns = false;
            this.dataGridViewListarColetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListarColetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.statusDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.solicitanteDataGridViewTextBoxColumn,
            this.setorDataGridViewTextBoxColumn,
            this.cCProjetoDataGridViewTextBoxColumn,
            this.dataNecessariaDataGridViewTextBoxColumn,
            this.periodoColetaDataGridViewTextBoxColumn,
            this.localColetaDataGridViewTextBoxColumn,
            this.localEntregaDataGridViewTextBoxColumn,
            this.materialDescricaoDataGridViewTextBoxColumn,
            this.materialDimensoesDataGridViewTextBoxColumn,
            this.materialPesoDataGridViewTextBoxColumn,
            this.quantidadeVolumeDataGridViewTextBoxColumn,
            this.obsDataGridViewTextBoxColumn,
            this.notaFiscalDataGridViewTextBoxColumn,
            this.valorNotaFiscalDataGridViewTextBoxColumn});
            this.dataGridViewListarColetas.DataSource = this.coletaModelBindingSource;
            this.dataGridViewListarColetas.Location = new System.Drawing.Point(0, 167);
            this.dataGridViewListarColetas.MultiSelect = false;
            this.dataGridViewListarColetas.Name = "dataGridViewListarColetas";
            this.dataGridViewListarColetas.ReadOnly = true;
            this.dataGridViewListarColetas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewListarColetas.RowTemplate.Height = 25;
            this.dataGridViewListarColetas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListarColetas.Size = new System.Drawing.Size(964, 554);
            this.dataGridViewListarColetas.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.relatóriosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(964, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fecharToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarParaOExcelToolStripMenuItem});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // exportarParaOExcelToolStripMenuItem
            // 
            this.exportarParaOExcelToolStripMenuItem.Name = "exportarParaOExcelToolStripMenuItem";
            this.exportarParaOExcelToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
            this.exportarParaOExcelToolStripMenuItem.Text = "Exportar todas coletas para arquivo excel";
            this.exportarParaOExcelToolStripMenuItem.Click += new System.EventHandler(this.exportarParaOExcelToolStripMenuItem_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Arial", 36F);
            this.labelTitulo.Location = new System.Drawing.Point(12, 24);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(560, 55);
            this.labelTitulo.TabIndex = 2;
            this.labelTitulo.Text = "Administração de coletas";
            // 
            // buttonIncluirColeta
            // 
            this.buttonIncluirColeta.Location = new System.Drawing.Point(12, 110);
            this.buttonIncluirColeta.Name = "buttonIncluirColeta";
            this.buttonIncluirColeta.Size = new System.Drawing.Size(90, 30);
            this.buttonIncluirColeta.TabIndex = 3;
            this.buttonIncluirColeta.Text = "Incluir";
            this.buttonIncluirColeta.UseVisualStyleBackColor = true;
            this.buttonIncluirColeta.Click += new System.EventHandler(this.buttonIcluirColeta_Click);
            // 
            // buttonEditarColeta
            // 
            this.buttonEditarColeta.Location = new System.Drawing.Point(204, 110);
            this.buttonEditarColeta.Name = "buttonEditarColeta";
            this.buttonEditarColeta.Size = new System.Drawing.Size(90, 30);
            this.buttonEditarColeta.TabIndex = 4;
            this.buttonEditarColeta.Text = "Editar";
            this.buttonEditarColeta.UseVisualStyleBackColor = true;
            this.buttonEditarColeta.Click += new System.EventHandler(this.buttonEditarColeta_Click);
            // 
            // buttonVisualizarColeta
            // 
            this.buttonVisualizarColeta.Location = new System.Drawing.Point(108, 110);
            this.buttonVisualizarColeta.Name = "buttonVisualizarColeta";
            this.buttonVisualizarColeta.Size = new System.Drawing.Size(90, 30);
            this.buttonVisualizarColeta.TabIndex = 5;
            this.buttonVisualizarColeta.Text = "Visualizar";
            this.buttonVisualizarColeta.UseVisualStyleBackColor = true;
            this.buttonVisualizarColeta.Click += new System.EventHandler(this.buttonVisualizarColeta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonListarTodasColetas);
            this.groupBox1.Controls.Add(this.labelStatus);
            this.groupBox1.Controls.Add(this.comboBoxStatus);
            this.groupBox1.Location = new System.Drawing.Point(300, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 79);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // buttonListarTodasColetas
            // 
            this.buttonListarTodasColetas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonListarTodasColetas.Location = new System.Drawing.Point(320, 29);
            this.buttonListarTodasColetas.Name = "buttonListarTodasColetas";
            this.buttonListarTodasColetas.Size = new System.Drawing.Size(90, 30);
            this.buttonListarTodasColetas.TabIndex = 7;
            this.buttonListarTodasColetas.Text = "Todos";
            this.buttonListarTodasColetas.UseVisualStyleBackColor = true;
            this.buttonListarTodasColetas.Click += new System.EventHandler(this.buttonListarTodaColetas_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(6, 34);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(49, 20);
            this.labelStatus.TabIndex = 37;
            this.labelStatus.Text = "Status";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "aguardando",
            "aguardando + em andamento",
            "concluído",
            "finalizada - sem coleta"});
            this.comboBoxStatus.Location = new System.Drawing.Point(62, 30);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(252, 28);
            this.comboBoxStatus.TabIndex = 36;
            this.comboBoxStatus.Text = "aguardando";
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            // 
            // coletaModelBindingSource
            // 
            this.coletaModelBindingSource.DataSource = typeof(Common.Models.ColetaModel);
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status da coleta";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "#";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 43;
            // 
            // solicitanteDataGridViewTextBoxColumn
            // 
            this.solicitanteDataGridViewTextBoxColumn.DataPropertyName = "solicitante";
            this.solicitanteDataGridViewTextBoxColumn.HeaderText = "Solicitante email:";
            this.solicitanteDataGridViewTextBoxColumn.Name = "solicitanteDataGridViewTextBoxColumn";
            this.solicitanteDataGridViewTextBoxColumn.ReadOnly = true;
            this.solicitanteDataGridViewTextBoxColumn.Width = 200;
            // 
            // setorDataGridViewTextBoxColumn
            // 
            this.setorDataGridViewTextBoxColumn.DataPropertyName = "setor";
            this.setorDataGridViewTextBoxColumn.HeaderText = "Setor";
            this.setorDataGridViewTextBoxColumn.Name = "setorDataGridViewTextBoxColumn";
            this.setorDataGridViewTextBoxColumn.ReadOnly = true;
            this.setorDataGridViewTextBoxColumn.Width = 110;
            // 
            // cCProjetoDataGridViewTextBoxColumn
            // 
            this.cCProjetoDataGridViewTextBoxColumn.DataPropertyName = "CC_Projeto";
            this.cCProjetoDataGridViewTextBoxColumn.HeaderText = "CC ou Projeto";
            this.cCProjetoDataGridViewTextBoxColumn.Name = "cCProjetoDataGridViewTextBoxColumn";
            this.cCProjetoDataGridViewTextBoxColumn.ReadOnly = true;
            this.cCProjetoDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataNecessariaDataGridViewTextBoxColumn
            // 
            this.dataNecessariaDataGridViewTextBoxColumn.DataPropertyName = "dataNecessaria";
            this.dataNecessariaDataGridViewTextBoxColumn.HeaderText = "Data da necessidade";
            this.dataNecessariaDataGridViewTextBoxColumn.Name = "dataNecessariaDataGridViewTextBoxColumn";
            this.dataNecessariaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataNecessariaDataGridViewTextBoxColumn.Width = 110;
            // 
            // periodoColetaDataGridViewTextBoxColumn
            // 
            this.periodoColetaDataGridViewTextBoxColumn.DataPropertyName = "periodoColeta";
            this.periodoColetaDataGridViewTextBoxColumn.HeaderText = "Período";
            this.periodoColetaDataGridViewTextBoxColumn.Name = "periodoColetaDataGridViewTextBoxColumn";
            this.periodoColetaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localColetaDataGridViewTextBoxColumn
            // 
            this.localColetaDataGridViewTextBoxColumn.DataPropertyName = "localColeta";
            this.localColetaDataGridViewTextBoxColumn.HeaderText = "Local de coleta";
            this.localColetaDataGridViewTextBoxColumn.Name = "localColetaDataGridViewTextBoxColumn";
            this.localColetaDataGridViewTextBoxColumn.ReadOnly = true;
            this.localColetaDataGridViewTextBoxColumn.Width = 200;
            // 
            // localEntregaDataGridViewTextBoxColumn
            // 
            this.localEntregaDataGridViewTextBoxColumn.DataPropertyName = "localEntrega";
            this.localEntregaDataGridViewTextBoxColumn.HeaderText = "Local de entrega";
            this.localEntregaDataGridViewTextBoxColumn.Name = "localEntregaDataGridViewTextBoxColumn";
            this.localEntregaDataGridViewTextBoxColumn.ReadOnly = true;
            this.localEntregaDataGridViewTextBoxColumn.Width = 200;
            // 
            // materialDescricaoDataGridViewTextBoxColumn
            // 
            this.materialDescricaoDataGridViewTextBoxColumn.DataPropertyName = "materialDescricao";
            this.materialDescricaoDataGridViewTextBoxColumn.HeaderText = "Descrição do material";
            this.materialDescricaoDataGridViewTextBoxColumn.Name = "materialDescricaoDataGridViewTextBoxColumn";
            this.materialDescricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.materialDescricaoDataGridViewTextBoxColumn.Width = 250;
            // 
            // materialDimensoesDataGridViewTextBoxColumn
            // 
            this.materialDimensoesDataGridViewTextBoxColumn.DataPropertyName = "materialDimensoes";
            this.materialDimensoesDataGridViewTextBoxColumn.HeaderText = "Dimensões do material CxLxA [mm]";
            this.materialDimensoesDataGridViewTextBoxColumn.Name = "materialDimensoesDataGridViewTextBoxColumn";
            this.materialDimensoesDataGridViewTextBoxColumn.ReadOnly = true;
            this.materialDimensoesDataGridViewTextBoxColumn.Width = 200;
            // 
            // materialPesoDataGridViewTextBoxColumn
            // 
            this.materialPesoDataGridViewTextBoxColumn.DataPropertyName = "materialPeso";
            this.materialPesoDataGridViewTextBoxColumn.HeaderText = "Peso do material [kg]";
            this.materialPesoDataGridViewTextBoxColumn.Name = "materialPesoDataGridViewTextBoxColumn";
            this.materialPesoDataGridViewTextBoxColumn.ReadOnly = true;
            this.materialPesoDataGridViewTextBoxColumn.Width = 130;
            // 
            // quantidadeVolumeDataGridViewTextBoxColumn
            // 
            this.quantidadeVolumeDataGridViewTextBoxColumn.DataPropertyName = "quantidadeVolume";
            this.quantidadeVolumeDataGridViewTextBoxColumn.HeaderText = "Quantidade de volumes";
            this.quantidadeVolumeDataGridViewTextBoxColumn.Name = "quantidadeVolumeDataGridViewTextBoxColumn";
            this.quantidadeVolumeDataGridViewTextBoxColumn.ReadOnly = true;
            this.quantidadeVolumeDataGridViewTextBoxColumn.Width = 110;
            // 
            // obsDataGridViewTextBoxColumn
            // 
            this.obsDataGridViewTextBoxColumn.DataPropertyName = "obs";
            this.obsDataGridViewTextBoxColumn.HeaderText = "Observações";
            this.obsDataGridViewTextBoxColumn.Name = "obsDataGridViewTextBoxColumn";
            this.obsDataGridViewTextBoxColumn.ReadOnly = true;
            this.obsDataGridViewTextBoxColumn.Width = 200;
            // 
            // notaFiscalDataGridViewTextBoxColumn
            // 
            this.notaFiscalDataGridViewTextBoxColumn.DataPropertyName = "notaFiscal";
            this.notaFiscalDataGridViewTextBoxColumn.HeaderText = "Numero da nota fiscal";
            this.notaFiscalDataGridViewTextBoxColumn.Name = "notaFiscalDataGridViewTextBoxColumn";
            this.notaFiscalDataGridViewTextBoxColumn.ReadOnly = true;
            this.notaFiscalDataGridViewTextBoxColumn.Width = 150;
            // 
            // valorNotaFiscalDataGridViewTextBoxColumn
            // 
            this.valorNotaFiscalDataGridViewTextBoxColumn.DataPropertyName = "valorNotaFiscal";
            this.valorNotaFiscalDataGridViewTextBoxColumn.HeaderText = "Valor da NF [R$]";
            this.valorNotaFiscalDataGridViewTextBoxColumn.Name = "valorNotaFiscalDataGridViewTextBoxColumn";
            this.valorNotaFiscalDataGridViewTextBoxColumn.ReadOnly = true;
            this.valorNotaFiscalDataGridViewTextBoxColumn.Width = 120;
            // 
            // FormAdministrarColeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 721);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonVisualizarColeta);
            this.Controls.Add(this.buttonEditarColeta);
            this.Controls.Add(this.buttonIncluirColeta);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.dataGridViewListarColetas);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormAdministrarColeta";
            this.Text = "HSA Coleta";
            this.Load += new System.EventHandler(this.FormAdministrarColeta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListarColetas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coletaModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewListarColetas;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem fecharToolStripMenuItem;
        private Label labelTitulo;
        private Button buttonIncluirColeta;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStripMenuItem exportarParaOExcelToolStripMenuItem;
        private Button buttonEditarColeta;
        private Button buttonVisualizarColeta;
        private GroupBox groupBox1;
        private Button buttonListarTodasColetas;
        private Label labelStatus;
        private ComboBox comboBoxStatus;
        private BindingSource coletaModelBindingSource;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn solicitanteDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn setorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cCProjetoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataNecessariaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn periodoColetaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn localColetaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn localEntregaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn materialDescricaoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn materialDimensoesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn materialPesoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantidadeVolumeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn obsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn notaFiscalDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorNotaFiscalDataGridViewTextBoxColumn;
    }
}
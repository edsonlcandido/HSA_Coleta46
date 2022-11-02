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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListarColetas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewListarColetas
            // 
            this.dataGridViewListarColetas.AllowUserToAddRows = false;
            this.dataGridViewListarColetas.AllowUserToDeleteRows = false;
            this.dataGridViewListarColetas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewListarColetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.labelTitulo.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.groupBox1.Size = new System.Drawing.Size(289, 79);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // buttonListarTodasColetas
            // 
            this.buttonListarTodasColetas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonListarTodasColetas.Location = new System.Drawing.Point(188, 28);
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
            "concluído",
            "finalizada - sem coleta"});
            this.comboBoxStatus.Location = new System.Drawing.Point(62, 30);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(120, 28);
            this.comboBoxStatus.TabIndex = 36;
            this.comboBoxStatus.Text = "aguardando";
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
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
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
    }
}
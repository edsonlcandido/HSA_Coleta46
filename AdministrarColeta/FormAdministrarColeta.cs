//using ClosedXML.Excel;
using Common.Models;
using Common.Presenters;
using Common.Repositories;
using HSA_Coleta;
using InserirColeta;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Reflection;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace HSA_Coleta
{
    public partial class FormAdministrarColeta : Form
    {
        private IColetaRepository _coletaRepository;
        private BindingSource _bindingSource;
        private IEnumerable<ColetaModel> _listaColetas;
        public FormAdministrarColeta(UsuarioModel usuario)
        {
            try
            {
                if (!usuario.ativo)
                {
                    throw new InvalidOperationException();
                }
                _coletaRepository = new ColetaRepository();
                _bindingSource = new BindingSource();
                _listaColetas = _coletaRepository.listarTodasAguardando();                
                InitializeComponent();
                updateBidingDataSource();
            }
            catch (InvalidOperationException)
            {
                throw;
            }
            catch  (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateBidingDataSource()
        {            
            _bindingSource.DataSource = _listaColetas;
            dataGridViewListarColetas.DataSource = _bindingSource;
        }

        private void FormAdministrarColeta_Load(object sender, EventArgs e)
        {
            updateBidingDataSource();
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            _listaColetas = _coletaRepository.filtrarPeloStatus(cb.Text);
            updateBidingDataSource();
        }

        private void buttonListarTodaColetas_Click(object sender, EventArgs e)
        {
            _listaColetas = _coletaRepository.listar();
            updateBidingDataSource();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEditarColeta_Click(object sender, EventArgs e)
        {
            ColetaModel coleta = (ColetaModel)_bindingSource.Current;
            ColetaPresenter coletaPresenter = new ColetaPresenter();
            coletaPresenter.titulo = "Editar coleta";
            coletaPresenter.editando = true;
            coletaPresenter.visualizando = false;
            FormInserirColeta form = new FormInserirColeta(coletaPresenter, coleta);
            form.ShowDialog();
            _listaColetas = _coletaRepository.listarTodasAguardando();
            updateBidingDataSource();
        }

        private void buttonIcluirColeta_Click(object sender, EventArgs e)
        {
            ColetaPresenter coletaPresenter = new ColetaPresenter();
            coletaPresenter.titulo = "Inserir coleta";
            coletaPresenter.editando = false;
            coletaPresenter.visualizando = false;
            FormInserirColeta form = new FormInserirColeta(coletaPresenter);
            form.ShowDialog();
            _listaColetas = _coletaRepository.listarTodasAguardando();
            updateBidingDataSource();
        }

        private void buttonVisualizarColeta_Click(object sender, EventArgs e)
        {
            ColetaModel coleta = (ColetaModel)_bindingSource.Current;
            ColetaPresenter coletaPresenter = new ColetaPresenter();
            coletaPresenter.titulo = "Visualizar coleta";
            coletaPresenter.editando = false;
            coletaPresenter.visualizando = true;
            FormInserirColeta form = new FormInserirColeta(coletaPresenter, coleta);
            form.ShowDialog();
        }

        private void exportarParaOExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("todasColetas");
            Type t = typeof(ColetaModel);
            PropertyInfo[] properties = t.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                Type columnType = property.PropertyType;
                dt.Columns.Add(property.Name, columnType);
            }
            IEnumerable<ColetaModel> todasColetas = _coletaRepository.listar();
            foreach (ColetaModel coleta in todasColetas)
            {
                DataRow dr = dt.NewRow();
                dr.BeginEdit();
                foreach (PropertyInfo property in properties)
                {
                    if (property.GetValue(coleta, null) != null)
                    {
                        dr[property.Name] = property.GetValue(coleta, null);
                    }
                }
                dr.EndEdit();
                dt.Rows.Add(dr);
            }
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Planilhas Excel|*.xlsx",
                Title = "Exportar planilha excel"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        int ColumnsCount;

                        Excel.Application excelApp = new Excel.Application();
                        excelApp.Workbooks.Add();
                        Excel._Worksheet workSheet = excelApp.ActiveSheet;

                        ColumnsCount = dt.Columns.Count;
                        object[] Header = new object[ColumnsCount];

                        // column headings
                        for (int i = 0; i < ColumnsCount; i++)
                            Header[i] = dt.Columns[i].ColumnName;

                        Excel.Range HeaderRange = workSheet.get_Range((Excel.Range)(workSheet.Cells[1, 1]), (Excel.Range)(workSheet.Cells[1, ColumnsCount]));
                        HeaderRange.Value = Header;

                        // DataCells
                        int RowsCount = dt.Rows.Count;
                        object[,] Cells = new object[RowsCount, ColumnsCount];

                        for (int j = 0; j < RowsCount; j++)
                            for (int i = 0; i < ColumnsCount; i++)
                                Cells[j, i] = dt.Rows[j][i];

                        workSheet.get_Range((Excel.Range)(workSheet.Cells[2, 1]), (Excel.Range)(workSheet.Cells[RowsCount + 1, ColumnsCount])).Value = Cells;

                        workSheet.SaveAs(sfd.FileName);
                        Console.WriteLine("Planilha Salva");
                        excelApp.Visible = true;

                        //using (XLWorkbook xLWorkbook = new XLWorkbook())
                        //{
                        //    xLWorkbook.Worksheets.Add(dt, "Coletas");
                        //    xLWorkbook.SaveAs(sfd.FileName);
                        //}

                        MessageBox.Show("Coletas exportadas para arquivo excel.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
    }
} 
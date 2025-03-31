// Se trata de una aplicaci�n de escritorio que permite la lectura, creaci�n, modificaci�n y eliminaci�n de registros en una hoja de Excel.
// Operativa basada en el uso del paquete EPPlus 8 (https://epplussoftware.com/)
// Este paquete permite la manipulaci�n de hojas de Excel sin necesidad de tener instalado Excel en el equipo.
// Adem�s permite su uso no comercial de forma gratuita, que para efectos funcionales es suficiente y adecuado para su uso formativo.

// Alugnas caracter�sticas de la aplicaci�n:
// Se ha utilizado un DataGridView para mostrar los registros de la hoja de Excel y TextBox para la introducci�n de datos.
// Se han implementado los eventos de los botones Examinar, Crear, Modificar, Eliminar y Salir.
// Se ha implementado un m�todo para refrescar el DataGridView con los datos de la hoja de Excel.
// Se ha implementado un m�todo para la creaci�n de un nuevo registro en la hoja de Excel.
// Se ha implementado un m�todo para la modificaci�n de un registro en la hoja de Excel.
// Se ha implementado un m�todo para la eliminaci�n de un registro en la hoja de Excel.
// Se ha implementado un m�todo para la lectura de los registros de la hoja de Excel y su visualizaci�n en el DataGridView.
// Se ha implementado un m�todo para la selecci�n de una fila del DataGridView y la visualizaci�n de sus datos en los TextBox.

using System.Data;
using OfficeOpenXml;


namespace CRUDExcelEPPlus
{
    public partial class Form1 : Form
    {

        private string nombreFichero; // @"C:\Proyectos\CRUDExcelEPPlus\origen.xlsx";
        private ExcelPackage? paqueteExcel;


        public Form1()
        {

            InitializeComponent();

            // Licencia EPPlus para uso no comercial.
            ExcelPackage.License.SetNonCommercialPersonal("Emilio Mart�n");
        
        }


        private void btnExaminar_Click(object sender, EventArgs e)
        {
            try
            {

                FileDialog fileDialog = new OpenFileDialog();
                fileDialog.Filter = "Fichero Excel|*.xls;*.xlsx;*.xlsm";
                fileDialog.Title = "Selecciona fichero Excel";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    nombreFichero = fileDialog.FileName;
                    
                    btnCrear.Enabled = true;
                    lblFichero.Text = nombreFichero;
                }
                refrescarGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el fichero Excel: " + ex.Message);
            }
        }



        private void dgvRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txtCodigo.Text = dgvRegistros.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgvRegistros.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = dgvRegistros.CurrentRow.Cells[2].Value.ToString();

            // S�lo si hay una fila seleccionada, es decir, el campo c�digo est� informado,
            // se habilitan los botones de Modificar y Eliminar.
            btnModificar.Enabled = string.IsNullOrEmpty(txtCodigo.Text) ? false : true;
            btnEliminar.Enabled = string.IsNullOrEmpty(txtCodigo.Text) ? false : true;

        }



        private void btnCrear_Click(object sender, EventArgs e)
        {
            // Comprobaciones: Habr�a que realizar comprobaciones previas (seg�n requerimientos) antes de insertar un registro/fila en la hoja Excel
            // Como ejemplo secillo se propone;
            //  1. Comprobar que los campos no est�n vac�os
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtApellido.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vac�os");
                return;
            }

            try
            {

                ExcelWorksheet hoja = paqueteExcel.Workbook.Worksheets[0];
                int ultimaFila = hoja.Dimension.End.Row;
                hoja.Cells[ultimaFila + 1, 1].Value = txtCodigo.Text;
                hoja.Cells[ultimaFila + 1, 2].Value = txtNombre.Text;
                hoja.Cells[ultimaFila + 1, 3].Value = txtApellido.Text;
                paqueteExcel.Save();
                refrescarGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la creaci�n. " + ex.Message);
                throw;
            }
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {

                ExcelWorksheet hoja = paqueteExcel.Workbook.Worksheets[0];
                hoja.Cells[dgvRegistros.CurrentRow.Index + 2, 1].Value = txtCodigo.Text;
                hoja.Cells[dgvRegistros.CurrentRow.Index + 2, 2].Value = txtNombre.Text;
                hoja.Cells[dgvRegistros.CurrentRow.Index + 2, 3].Value = txtApellido.Text;
                paqueteExcel.Save();
                refrescarGridView();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la modificaci�n. " + ex.Message);
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
             
                if(MessageBox.Show("�Est�s seguro de eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                   
                    ExcelWorksheet hoja = paqueteExcel.Workbook.Worksheets[0];
                    hoja.DeleteRow(dgvRegistros.CurrentRow.Index + 2);
                    paqueteExcel.Save();
                    refrescarGridView();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la eliminaci�n. " + ex.Message);
            }
        }



        private void refrescarGridView()
        {
            try
            {

                DataTable dtTable = new DataTable();

                paqueteExcel = new ExcelPackage(new FileInfo(nombreFichero));
                ExcelWorksheet hoja = paqueteExcel.Workbook.Worksheets[0];

                int totalColumnas = hoja.Dimension.End.Column;
                int totalFilas = hoja.Dimension.End.Row;
                
                // Gesti�n de la fila de cabecera
                for (int col = 1; col <= totalColumnas; col++)
                {
                    dtTable.Columns.Add(hoja.Cells[1, col].Text);
                }

                // Gesti�n de las filas con contenido
                for (int row = 2; row <= totalFilas; row++)
                {
                    DataRow dataRow = dtTable.NewRow();
                    for (int col = 1; col <= totalColumnas; col++)
                    {
                        dataRow[col - 1] = hoja.Cells[row, col].Text;
                    }
                    dtTable.Rows.Add(dataRow);
                }

                dgvRegistros.DataSource = dtTable;

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     
    }
}

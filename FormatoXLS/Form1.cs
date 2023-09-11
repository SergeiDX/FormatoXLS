using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormatoXLS
{
    public partial class Form1 : Form
    {
        conexion conexion = new conexion();

        public void LlenarDatos()
        {
            conexion.cnn.Open();
            SqlCommand cmd = new SqlCommand("spAgregarCurso",conexion.cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_Curso", txtIDcurso.Text);
            cmd.Parameters.AddWithValue("@Descripcion",txtDescripcion.Text);
            cmd.Parameters.AddWithValue("@DuracionHrs", txtHRS.Text);
            cmd.Parameters.AddWithValue("@DuracionDias", txtDias.Text);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Curso agregado correctamente.");
              
            }
            catch (SqlException EX)
            {
                MessageBox.Show(EX.ToString());
                throw;
            }
            conexion.cnn.Close();
            LimpiarCampos();
        }
        public void LimpiarCampos()
        {
            txtDescripcion.Clear();
            txtDias.Clear();
            txtHRS.Clear();
            txtDias.Clear();
        }
        public void MostrarDatos()
        {
            
            string consulta = "select * from Cursos";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion.cnn);
            System.Data.DataTable dt = new System.Data.DataTable();
            adaptador.Fill(dt);
            dataGridView1.DataSource = dt;
            
        }

       public void ExportarDatos(DataGridView datalistado)
        {
            Microsoft.Office.Interop.Excel.Application exportarexcel = new Microsoft.Office.Interop.Excel.Application();
            exportarexcel.Application.Workbooks.Add(true);

            int indicecolumna = 0;

            foreach (DataGridViewColumn columna in datalistado.Columns)
            {
                indicecolumna++;
                exportarexcel.Cells[1, indicecolumna] = columna.Name;
            }

            int indicefila = 0;
            foreach (DataGridViewRow fila in datalistado.Rows)
            {
                indicefila++;
                indicecolumna = 0;
                foreach (DataGridViewColumn columna in datalistado.Columns)
                {
                    indicecolumna++;
                    exportarexcel.Cells[indicefila + 1, indicecolumna] = fila.Cells[columna.Name].Value;
                }
            }

            exportarexcel.Visible = true;
        }

        private void ExportarDataGridViewAExcel(DataGridView dgv)
        {
            try
            {
                
                var excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Visible = true;

                
                Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
                Worksheet worksheet = workbook.Sheets[1];

                
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 1, j + 1] = dgv.Rows[i].Cells[j].Value;
                    }
                }

                System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);

                MessageBox.Show("Datos exportados correctamente a Excel", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar los datos a Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnXLS_Click(object sender, EventArgs e)
        {
            LlenarDatos();
            ExportarDataGridViewAExcel(dataGridView1);
        }
    }









}

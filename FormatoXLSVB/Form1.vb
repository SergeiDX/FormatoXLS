Imports System.Data.SqlClient

Public Class Form1
    Public cnn As SqlConnection = New SqlConnection("Server=DESKTOP-EUB75BK;Database=Capacitacion;Integrated Security=True")


    Public Sub MostrarDatos()
        Dim consulta As String = "select * from Cursos"
        Dim adaptador As SqlDataAdapter = New SqlDataAdapter(consulta, cnn)
        Dim dt As System.Data.DataTable = New System.Data.DataTable()
        adaptador.Fill(dt)
        dataGridView1.DataSource = dt
    End Sub

    Private Sub ExportarDataGridViewAExcel(ByVal dgv As DataGridView)
        Try
            Dim excelApp = New Microsoft.Office.Interop.Excel.Application()
            excelApp.Visible = True
            Dim workbook As Microsoft.Office.Interop.Excel.Workbook = excelApp.Workbooks.Add(Type.Missing)
            Dim worksheet As Microsoft.Office.Interop.Excel.Worksheet = workbook.Sheets(1)

            For i As Integer = 0 To dgv.Rows.Count - 1

                For j As Integer = 0 To dgv.Columns.Count - 1
                    worksheet.Cells(i + 1, j + 1) = dgv.Rows(i).Cells(j).Value
                Next
            Next

            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)
            MessageBox.Show("Datos exportados correctamente a Excel", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al exportar los datos a Excel: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        End Try
    End Sub


    Public Sub LlenarDatos()
        cnn.Open()
        Dim cmd As SqlCommand = New SqlCommand("spAgregarCurso", cnn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@id_Curso", txtIDcurso.Text)
        cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text)
        cmd.Parameters.AddWithValue("@DuracionHrs", txtHRS.Text)
        cmd.Parameters.AddWithValue("@DuracionDias", txtDias.Text)

        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Curso agregado correctamente.")
        Catch EX As SqlException
            MessageBox.Show(EX.ToString())
            Throw
        End Try

        cnn.Close()
        LimpiarCampos()
    End Sub

    Public Sub LimpiarCampos()
        txtDescripcion.Clear()
        txtDias.Clear()
        txtHRS.Clear()
        txtIDcurso.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarDatos()
    End Sub

    Private Sub btnXLS_Click(sender As Object, e As EventArgs) Handles btnXLS.Click
        ExportarDataGridViewAExcel(dataGridView1)
    End Sub
End Class

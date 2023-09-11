<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnXLS = New System.Windows.Forms.Button()
        Me.txtDias = New System.Windows.Forms.TextBox()
        Me.txtHRS = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtIDcurso = New System.Windows.Forms.TextBox()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(96, 100)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(74, 13)
        Me.label4.TabIndex = 19
        Me.label4.Text = "Duracion Dias"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(89, 74)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(81, 13)
        Me.label3.TabIndex = 18
        Me.label3.Text = "Duracion Horas"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(107, 44)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(63, 13)
        Me.label2.TabIndex = 17
        Me.label2.Text = "Descripcion"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(125, 14)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(45, 13)
        Me.label1.TabIndex = 16
        Me.label1.Text = "id Curso"
        '
        'btnXLS
        '
        Me.btnXLS.BackgroundImage = Global.FormatoXLSVB.My.Resources.Resources.xls_file_format
        Me.btnXLS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnXLS.Location = New System.Drawing.Point(314, 44)
        Me.btnXLS.Name = "btnXLS"
        Me.btnXLS.Size = New System.Drawing.Size(59, 49)
        Me.btnXLS.TabIndex = 15
        Me.btnXLS.UseVisualStyleBackColor = True
        '
        'txtDias
        '
        Me.txtDias.Location = New System.Drawing.Point(177, 97)
        Me.txtDias.Name = "txtDias"
        Me.txtDias.Size = New System.Drawing.Size(100, 20)
        Me.txtDias.TabIndex = 14
        '
        'txtHRS
        '
        Me.txtHRS.Location = New System.Drawing.Point(177, 71)
        Me.txtHRS.Name = "txtHRS"
        Me.txtHRS.Size = New System.Drawing.Size(100, 20)
        Me.txtHRS.TabIndex = 13
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(177, 41)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(100, 20)
        Me.txtDescripcion.TabIndex = 12
        '
        'txtIDcurso
        '
        Me.txtIDcurso.Location = New System.Drawing.Point(177, 11)
        Me.txtIDcurso.MaxLength = 6
        Me.txtIDcurso.Name = "txtIDcurso"
        Me.txtIDcurso.Size = New System.Drawing.Size(100, 20)
        Me.txtIDcurso.TabIndex = 11
        Me.txtIDcurso.Text = "0000"
        '
        'dataGridView1
        '
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Location = New System.Drawing.Point(12, 123)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(449, 166)
        Me.dataGridView1.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 303)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.btnXLS)
        Me.Controls.Add(Me.txtDias)
        Me.Controls.Add(Me.txtHRS)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtIDcurso)
        Me.Controls.Add(Me.dataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
    Private WithEvents btnXLS As Button
    Private WithEvents txtDias As TextBox
    Private WithEvents txtHRS As TextBox
    Private WithEvents txtDescripcion As TextBox
    Private WithEvents txtIDcurso As TextBox
    Private WithEvents dataGridView1 As DataGridView
End Class

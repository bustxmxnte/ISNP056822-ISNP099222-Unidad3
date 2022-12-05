<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Alumnos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.datosAlumno = New System.Windows.Forms.DataGridView()
        Me.grpCodigo = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Txtcodigo = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Txtcarrera = New System.Windows.Forms.TextBox()
        Me.Txtedad = New System.Windows.Forms.TextBox()
        Me.Txtcorreo = New System.Windows.Forms.TextBox()
        Me.Txtgenero = New System.Windows.Forms.TextBox()
        Me.Txtapellido = New System.Windows.Forms.TextBox()
        Me.Txtdui = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txtnombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Carrera = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.datosAlumno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCodigo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'datosAlumno
        '
        Me.datosAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datosAlumno.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Column1, Me.Column2, Me.Column3, Me.Column5, Me.Column6, Me.Column7, Me.Carrera})
        Me.datosAlumno.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.datosAlumno.Location = New System.Drawing.Point(287, 569)
        Me.datosAlumno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.datosAlumno.Name = "datosAlumno"
        Me.datosAlumno.RowHeadersWidth = 51
        Me.datosAlumno.Size = New System.Drawing.Size(1132, 256)
        Me.datosAlumno.TabIndex = 22
        '
        'grpCodigo
        '
        Me.grpCodigo.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.grpCodigo.Controls.Add(Me.Label9)
        Me.grpCodigo.Controls.Add(Me.Txtcodigo)
        Me.grpCodigo.Controls.Add(Me.btnAgregar)
        Me.grpCodigo.Controls.Add(Me.btnGenerar)
        Me.grpCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCodigo.Location = New System.Drawing.Point(287, 428)
        Me.grpCodigo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpCodigo.Name = "grpCodigo"
        Me.grpCodigo.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpCodigo.Size = New System.Drawing.Size(1132, 124)
        Me.grpCodigo.TabIndex = 21
        Me.grpCodigo.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(41, 27)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 20)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Código"
        '
        'Txtcodigo
        '
        Me.Txtcodigo.Location = New System.Drawing.Point(45, 50)
        Me.Txtcodigo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtcodigo.Name = "Txtcodigo"
        Me.Txtcodigo.ReadOnly = True
        Me.Txtcodigo.Size = New System.Drawing.Size(261, 28)
        Me.Txtcodigo.TabIndex = 1
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(760, 44)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(197, 42)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar Alumno"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(355, 44)
        Me.btnGenerar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(197, 43)
        Me.btnGenerar.TabIndex = 0
        Me.btnGenerar.Text = "Generar Código"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(565, 6)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(557, 36)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "INGRESO DE DATOS ESTUDIANTES"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox1.Controls.Add(Me.Txtcarrera)
        Me.GroupBox1.Controls.Add(Me.Txtedad)
        Me.GroupBox1.Controls.Add(Me.Txtcorreo)
        Me.GroupBox1.Controls.Add(Me.Txtgenero)
        Me.GroupBox1.Controls.Add(Me.Txtapellido)
        Me.GroupBox1.Controls.Add(Me.Txtdui)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(287, 81)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1144, 340)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'Txtcarrera
        '
        Me.Txtcarrera.Location = New System.Drawing.Point(601, 277)
        Me.Txtcarrera.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtcarrera.Name = "Txtcarrera"
        Me.Txtcarrera.Size = New System.Drawing.Size(505, 22)
        Me.Txtcarrera.TabIndex = 27
        '
        'Txtedad
        '
        Me.Txtedad.Location = New System.Drawing.Point(884, 167)
        Me.Txtedad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtedad.Name = "Txtedad"
        Me.Txtedad.Size = New System.Drawing.Size(223, 22)
        Me.Txtedad.TabIndex = 26
        '
        'Txtcorreo
        '
        Me.Txtcorreo.Location = New System.Drawing.Point(45, 277)
        Me.Txtcorreo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtcorreo.Name = "Txtcorreo"
        Me.Txtcorreo.Size = New System.Drawing.Size(505, 22)
        Me.Txtcorreo.TabIndex = 25
        '
        'Txtgenero
        '
        Me.Txtgenero.Location = New System.Drawing.Point(601, 167)
        Me.Txtgenero.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtgenero.Name = "Txtgenero"
        Me.Txtgenero.Size = New System.Drawing.Size(223, 22)
        Me.Txtgenero.TabIndex = 24
        '
        'Txtapellido
        '
        Me.Txtapellido.Location = New System.Drawing.Point(601, 66)
        Me.Txtapellido.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtapellido.Name = "Txtapellido"
        Me.Txtapellido.Size = New System.Drawing.Size(505, 22)
        Me.Txtapellido.TabIndex = 23
        '
        'Txtdui
        '
        Me.Txtdui.Location = New System.Drawing.Point(45, 167)
        Me.Txtdui.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtdui.Name = "Txtdui"
        Me.Txtdui.Size = New System.Drawing.Size(255, 22)
        Me.Txtdui.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(597, 254)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 20)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Carrera:"
        '
        'Txtnombre
        '
        Me.Txtnombre.Location = New System.Drawing.Point(45, 66)
        Me.Txtnombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtnombre.Name = "Txtnombre"
        Me.Txtnombre.Size = New System.Drawing.Size(505, 22)
        Me.Txtnombre.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(41, 254)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 20)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Correo:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(597, 144)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 20)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Género:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(880, 144)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Edad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(41, 144)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "DUI:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(597, 36)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Apellido:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nombre:"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Código"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 125
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nombre"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Apellido"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Genero"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "DUI"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "Edad"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 125
        '
        'Column7
        '
        Me.Column7.HeaderText = "Correo"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 125
        '
        'Carrera
        '
        Me.Carrera.HeaderText = "Carrera"
        Me.Carrera.MinimumWidth = 6
        Me.Carrera.Name = "Carrera"
        Me.Carrera.Width = 125
        '
        'Form_Alumnos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1700, 839)
        Me.Controls.Add(Me.datosAlumno)
        Me.Controls.Add(Me.grpCodigo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form_Alumnos"
        Me.Text = "Formulario Estudiantes"
        CType(Me.datosAlumno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCodigo.ResumeLayout(False)
        Me.grpCodigo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents datosAlumno As DataGridView
    Friend WithEvents grpCodigo As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Txtcodigo As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnGenerar As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Txtcarrera As TextBox
    Friend WithEvents Txtedad As TextBox
    Friend WithEvents Txtcorreo As TextBox
    Friend WithEvents Txtgenero As TextBox
    Friend WithEvents Txtapellido As TextBox
    Friend WithEvents Txtdui As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Txtnombre As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Carrera As DataGridViewTextBoxColumn
End Class

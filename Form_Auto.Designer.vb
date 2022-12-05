<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Auto
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txtmarca = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtaño = New System.Windows.Forms.TextBox()
        Me.txtmodelo = New System.Windows.Forms.TextBox()
        Me.txtcolor = New System.Windows.Forms.TextBox()
        Me.txtchasis = New System.Windows.Forms.TextBox()
        Me.txtclase = New System.Windows.Forms.TextBox()
        Me.txtmotor = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnGenerar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.grpCodigo = New System.Windows.Forms.GroupBox()
        Me.datosauto = New System.Windows.Forms.DataGridView()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.grpCodigo.SuspendLayout()
        CType(Me.datosauto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(136, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Marca:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(445, 47)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Modelo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(765, 47)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Año:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(765, 138)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Clase:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(136, 138)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Color:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(136, 228)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 20)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Número de Chasis:"
        '
        'Txtmarca
        '
        Me.Txtmarca.Location = New System.Drawing.Point(140, 78)
        Me.Txtmarca.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtmarca.Name = "Txtmarca"
        Me.Txtmarca.Size = New System.Drawing.Size(261, 22)
        Me.Txtmarca.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(628, 228)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 20)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Número de Motor:"
        '
        'txtaño
        '
        Me.txtaño.Location = New System.Drawing.Point(769, 78)
        Me.txtaño.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtaño.Name = "txtaño"
        Me.txtaño.Size = New System.Drawing.Size(268, 22)
        Me.txtaño.TabIndex = 22
        '
        'txtmodelo
        '
        Me.txtmodelo.Location = New System.Drawing.Point(449, 78)
        Me.txtmodelo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtmodelo.Name = "txtmodelo"
        Me.txtmodelo.Size = New System.Drawing.Size(261, 22)
        Me.txtmodelo.TabIndex = 23
        '
        'txtcolor
        '
        Me.txtcolor.Location = New System.Drawing.Point(140, 161)
        Me.txtcolor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtcolor.Name = "txtcolor"
        Me.txtcolor.Size = New System.Drawing.Size(261, 22)
        Me.txtcolor.TabIndex = 24
        '
        'txtchasis
        '
        Me.txtchasis.Location = New System.Drawing.Point(140, 251)
        Me.txtchasis.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtchasis.Name = "txtchasis"
        Me.txtchasis.Size = New System.Drawing.Size(411, 22)
        Me.txtchasis.TabIndex = 25
        '
        'txtclase
        '
        Me.txtclase.Location = New System.Drawing.Point(769, 161)
        Me.txtclase.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtclase.Name = "txtclase"
        Me.txtclase.Size = New System.Drawing.Size(268, 22)
        Me.txtclase.TabIndex = 26
        '
        'txtmotor
        '
        Me.txtmotor.Location = New System.Drawing.Point(632, 251)
        Me.txtmotor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtmotor.Name = "txtmotor"
        Me.txtmotor.Size = New System.Drawing.Size(405, 22)
        Me.txtmotor.TabIndex = 27
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.GroupBox1.Controls.Add(Me.txtmotor)
        Me.GroupBox1.Controls.Add(Me.txtclase)
        Me.GroupBox1.Controls.Add(Me.txtchasis)
        Me.GroupBox1.Controls.Add(Me.txtcolor)
        Me.GroupBox1.Controls.Add(Me.txtmodelo)
        Me.GroupBox1.Controls.Add(Me.txtaño)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Txtmarca)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(268, 114)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(1129, 340)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(549, 39)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(496, 36)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "INGRESO DE DATOS DE AUTOS"
        '
        'btnGenerar
        '
        Me.btnGenerar.Location = New System.Drawing.Point(411, 47)
        Me.btnGenerar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGenerar.Name = "btnGenerar"
        Me.btnGenerar.Size = New System.Drawing.Size(197, 43)
        Me.btnGenerar.TabIndex = 0
        Me.btnGenerar.Text = "Generar placa"
        Me.btnGenerar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(769, 47)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(197, 42)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar Auto"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Txtcodigo
        '
        Me.Txtcodigo.BackColor = System.Drawing.SystemColors.Window
        Me.Txtcodigo.Location = New System.Drawing.Point(140, 53)
        Me.Txtcodigo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtcodigo.Name = "Txtcodigo"
        Me.Txtcodigo.ReadOnly = True
        Me.Txtcodigo.Size = New System.Drawing.Size(261, 28)
        Me.Txtcodigo.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(136, 30)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(159, 20)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Número de Placa:"
        '
        'grpCodigo
        '
        Me.grpCodigo.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.grpCodigo.Controls.Add(Me.Label9)
        Me.grpCodigo.Controls.Add(Me.Txtcodigo)
        Me.grpCodigo.Controls.Add(Me.btnAgregar)
        Me.grpCodigo.Controls.Add(Me.btnGenerar)
        Me.grpCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCodigo.Location = New System.Drawing.Point(268, 462)
        Me.grpCodigo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpCodigo.Name = "grpCodigo"
        Me.grpCodigo.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpCodigo.Size = New System.Drawing.Size(1129, 124)
        Me.grpCodigo.TabIndex = 17
        Me.grpCodigo.TabStop = False
        '
        'datosauto
        '
        Me.datosauto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datosauto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column8, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.datosauto.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.datosauto.Location = New System.Drawing.Point(268, 610)
        Me.datosauto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.datosauto.Name = "datosauto"
        Me.datosauto.RowHeadersWidth = 51
        Me.datosauto.Size = New System.Drawing.Size(1129, 256)
        Me.datosauto.TabIndex = 18
        '
        'Column8
        '
        Me.Column8.HeaderText = "Marca"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 125
        '
        'Column1
        '
        Me.Column1.HeaderText = "Modelo"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Año"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Color"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "Clase"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Número Chasis"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "Número Motor"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 125
        '
        'Column7
        '
        Me.Column7.HeaderText = "Número Placa"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 125
        '
        'Form_Auto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1703, 912)
        Me.Controls.Add(Me.datosauto)
        Me.Controls.Add(Me.grpCodigo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form_Auto"
        Me.Text = " "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpCodigo.ResumeLayout(False)
        Me.grpCodigo.PerformLayout()
        CType(Me.datosauto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Txtmarca As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtaño As TextBox
    Friend WithEvents txtmodelo As TextBox
    Friend WithEvents txtcolor As TextBox
    Friend WithEvents txtchasis As TextBox
    Friend WithEvents txtclase As TextBox
    Friend WithEvents txtmotor As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents btnGenerar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Txtcodigo As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents grpCodigo As GroupBox
    Friend WithEvents datosauto As DataGridView
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class

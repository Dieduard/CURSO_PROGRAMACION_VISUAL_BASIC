<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtEdad = New System.Windows.Forms.TextBox()
        Me.txtSueldo = New System.Windows.Forms.TextBox()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.DgvDatos = New System.Windows.Forms.DataGridView()
        Me.rdbHombre = New System.Windows.Forms.RadioButton()
        Me.rdbMujer = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblHombres = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblMujeres = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.DgvDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 51)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(57, 113)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Edad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 178)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Sueldo:"
        '
        'txtnombre
        '
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(160, 40)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(148, 24)
        Me.txtnombre.TabIndex = 4
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(160, 70)
        Me.txtApellido.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(148, 24)
        Me.txtApellido.TabIndex = 5
        '
        'txtEdad
        '
        Me.txtEdad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEdad.Location = New System.Drawing.Point(160, 102)
        Me.txtEdad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEdad.Name = "txtEdad"
        Me.txtEdad.Size = New System.Drawing.Size(148, 24)
        Me.txtEdad.TabIndex = 6
        '
        'txtSueldo
        '
        Me.txtSueldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSueldo.Location = New System.Drawing.Point(154, 167)
        Me.txtSueldo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.Size = New System.Drawing.Size(148, 24)
        Me.txtSueldo.TabIndex = 7
        '
        'btnMostrar
        '
        Me.btnMostrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrar.Location = New System.Drawing.Point(336, 44)
        Me.btnMostrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(180, 32)
        Me.btnMostrar.TabIndex = 8
        Me.btnMostrar.Text = "Agregar Datos"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'DgvDatos
        '
        Me.DgvDatos.AllowUserToAddRows = False
        Me.DgvDatos.AllowUserToDeleteRows = False
        Me.DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDatos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column6, Me.Column5, Me.Column4})
        Me.DgvDatos.Location = New System.Drawing.Point(13, 200)
        Me.DgvDatos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DgvDatos.Name = "DgvDatos"
        Me.DgvDatos.ReadOnly = True
        Me.DgvDatos.Size = New System.Drawing.Size(645, 228)
        Me.DgvDatos.TabIndex = 9
        '
        'rdbHombre
        '
        Me.rdbHombre.AutoSize = True
        Me.rdbHombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbHombre.Location = New System.Drawing.Point(160, 141)
        Me.rdbHombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdbHombre.Name = "rdbHombre"
        Me.rdbHombre.Size = New System.Drawing.Size(80, 22)
        Me.rdbHombre.TabIndex = 10
        Me.rdbHombre.TabStop = True
        Me.rdbHombre.Text = "Hombre"
        Me.rdbHombre.UseVisualStyleBackColor = True
        '
        'rdbMujer
        '
        Me.rdbMujer.AutoSize = True
        Me.rdbMujer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMujer.Location = New System.Drawing.Point(245, 141)
        Me.rdbMujer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdbMujer.Name = "rdbMujer"
        Me.rdbMujer.Size = New System.Drawing.Size(63, 22)
        Me.rdbMujer.TabIndex = 11
        Me.rdbMujer.TabStop = True
        Me.rdbMujer.Text = "Mujer"
        Me.rdbMujer.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(60, 143)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Sexo"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nombre"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Apellido"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Edad"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Sexo"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Sueldo"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Mensaje"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 442)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Hombres:"
        '
        'lblHombres
        '
        Me.lblHombres.AutoSize = True
        Me.lblHombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHombres.Location = New System.Drawing.Point(146, 442)
        Me.lblHombres.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHombres.Name = "lblHombres"
        Me.lblHombres.Size = New System.Drawing.Size(33, 20)
        Me.lblHombres.TabIndex = 14
        Me.lblHombres.Text = "****"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(28, 472)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 20)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Mujeres:"
        '
        'lblMujeres
        '
        Me.lblMujeres.AutoSize = True
        Me.lblMujeres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMujeres.Location = New System.Drawing.Point(146, 472)
        Me.lblMujeres.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMujeres.Name = "lblMujeres"
        Me.lblMujeres.Size = New System.Drawing.Size(33, 20)
        Me.lblMujeres.TabIndex = 16
        Me.lblMujeres.Text = "****"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(336, 80)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(180, 30)
        Me.btnLimpiar.TabIndex = 17
        Me.btnLimpiar.Text = "Limpiar Campos"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(441, 116)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 27)
        Me.btnSalir.TabIndex = 18
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 503)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.lblMujeres)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblHombres)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rdbMujer)
        Me.Controls.Add(Me.rdbHombre)
        Me.Controls.Add(Me.DgvDatos)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.txtSueldo)
        Me.Controls.Add(Me.txtEdad)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DgvDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtEdad As TextBox
    Friend WithEvents txtSueldo As TextBox
    Friend WithEvents btnMostrar As Button
    Friend WithEvents DgvDatos As DataGridView
    Friend WithEvents rdbHombre As RadioButton
    Friend WithEvents rdbMujer As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Label6 As Label
    Friend WithEvents lblHombres As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblMujeres As Label
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
End Class

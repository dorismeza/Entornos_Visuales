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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labelu = New System.Windows.Forms.Label()
        Me.label = New System.Windows.Forms.Label()
        Me.labell = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCadena = New System.Windows.Forms.TextBox()
        Me.txtBorrar = New System.Windows.Forms.TextBox()
        Me.txtMinusculas = New System.Windows.Forms.TextBox()
        Me.txtMayusculas = New System.Windows.Forms.TextBox()
        Me.txtPosicion = New System.Windows.Forms.TextBox()
        Me.txtPrimero = New System.Windows.Forms.TextBox()
        Me.txtUltimo = New System.Windows.Forms.TextBox()
        Me.txtLongitud = New System.Windows.Forms.TextBox()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtPosicionFija = New System.Windows.Forms.TextBox()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cadena"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Longitud"
        '
        'labelu
        '
        Me.labelu.AutoSize = True
        Me.labelu.Location = New System.Drawing.Point(59, 111)
        Me.labelu.Name = "labelu"
        Me.labelu.Size = New System.Drawing.Size(79, 13)
        Me.labelu.TabIndex = 2
        Me.labelu.Text = "Ultimo Caracter"
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(59, 153)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(79, 13)
        Me.label.TabIndex = 3
        Me.label.Text = "Primer Caracter"
        '
        'labell
        '
        Me.labell.AutoSize = True
        Me.labell.Location = New System.Drawing.Point(59, 199)
        Me.labell.Name = "labell"
        Me.labell.Size = New System.Drawing.Size(54, 13)
        Me.labell.TabIndex = 4
        Me.labell.Text = "3ro al 8vo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(59, 242)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Posicion de  la letra B"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(59, 287)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Mayusculas"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(59, 333)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Minusculas"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(59, 378)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Borrar espacios"
        '
        'txtCadena
        '
        Me.txtCadena.Location = New System.Drawing.Point(178, 20)
        Me.txtCadena.Name = "txtCadena"
        Me.txtCadena.Size = New System.Drawing.Size(100, 20)
        Me.txtCadena.TabIndex = 9
        '
        'txtBorrar
        '
        Me.txtBorrar.Location = New System.Drawing.Point(178, 375)
        Me.txtBorrar.Name = "txtBorrar"
        Me.txtBorrar.Size = New System.Drawing.Size(100, 20)
        Me.txtBorrar.TabIndex = 10
        '
        'txtMinusculas
        '
        Me.txtMinusculas.Location = New System.Drawing.Point(178, 333)
        Me.txtMinusculas.Name = "txtMinusculas"
        Me.txtMinusculas.Size = New System.Drawing.Size(100, 20)
        Me.txtMinusculas.TabIndex = 11
        '
        'txtMayusculas
        '
        Me.txtMayusculas.Location = New System.Drawing.Point(178, 284)
        Me.txtMayusculas.Name = "txtMayusculas"
        Me.txtMayusculas.Size = New System.Drawing.Size(100, 20)
        Me.txtMayusculas.TabIndex = 12
        '
        'txtPosicion
        '
        Me.txtPosicion.Location = New System.Drawing.Point(179, 242)
        Me.txtPosicion.Name = "txtPosicion"
        Me.txtPosicion.Size = New System.Drawing.Size(100, 20)
        Me.txtPosicion.TabIndex = 13
        '
        'txtPrimero
        '
        Me.txtPrimero.Location = New System.Drawing.Point(178, 146)
        Me.txtPrimero.Name = "txtPrimero"
        Me.txtPrimero.Size = New System.Drawing.Size(100, 20)
        Me.txtPrimero.TabIndex = 15
        '
        'txtUltimo
        '
        Me.txtUltimo.Location = New System.Drawing.Point(178, 111)
        Me.txtUltimo.Name = "txtUltimo"
        Me.txtUltimo.Size = New System.Drawing.Size(100, 20)
        Me.txtUltimo.TabIndex = 16
        '
        'txtLongitud
        '
        Me.txtLongitud.Location = New System.Drawing.Point(178, 64)
        Me.txtLongitud.Name = "txtLongitud"
        Me.txtLongitud.Size = New System.Drawing.Size(100, 20)
        Me.txtLongitud.TabIndex = 17
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(321, 41)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(75, 23)
        Me.btnMostrar.TabIndex = 18
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'txtPosicionFija
        '
        Me.txtPosicionFija.Location = New System.Drawing.Point(178, 192)
        Me.txtPosicionFija.Name = "txtPosicionFija"
        Me.txtPosicionFija.Size = New System.Drawing.Size(100, 20)
        Me.txtPosicionFija.TabIndex = 19
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 450)
        Me.Controls.Add(Me.txtPosicionFija)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.txtLongitud)
        Me.Controls.Add(Me.txtUltimo)
        Me.Controls.Add(Me.txtPrimero)
        Me.Controls.Add(Me.txtPosicion)
        Me.Controls.Add(Me.txtMayusculas)
        Me.Controls.Add(Me.txtMinusculas)
        Me.Controls.Add(Me.txtBorrar)
        Me.Controls.Add(Me.txtCadena)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.labell)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.labelu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Funcion String"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents labelu As Label
    Friend WithEvents label As Label
    Friend WithEvents labell As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCadena As TextBox
    Friend WithEvents txtBorrar As TextBox
    Friend WithEvents txtMinusculas As TextBox
    Friend WithEvents txtMayusculas As TextBox
    Friend WithEvents txtPosicion As TextBox
    Friend WithEvents txtPrimero As TextBox
    Friend WithEvents txtUltimo As TextBox
    Friend WithEvents txtLongitud As TextBox
    Friend WithEvents btnMostrar As Button
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents txtPosicionFija As TextBox
End Class

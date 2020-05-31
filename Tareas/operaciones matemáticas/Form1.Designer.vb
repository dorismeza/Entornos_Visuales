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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtdivision = New System.Windows.Forms.TextBox()
        Me.division = New System.Windows.Forms.Label()
        Me.txtmultiplicacion = New System.Windows.Forms.TextBox()
        Me.txtResta = New System.Windows.Forms.TextBox()
        Me.txtSuma = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.multiplicacion = New System.Windows.Forms.Label()
        Me.resta = New System.Windows.Forms.Label()
        Me.suma = New System.Windows.Forms.Label()
        Me.txtValor2 = New System.Windows.Forms.TextBox()
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.valor2 = New System.Windows.Forms.Label()
        Me.valor1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(272, 301)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 27
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'txtdivision
        '
        Me.txtdivision.Location = New System.Drawing.Point(115, 205)
        Me.txtdivision.Name = "txtdivision"
        Me.txtdivision.Size = New System.Drawing.Size(100, 20)
        Me.txtdivision.TabIndex = 26
        '
        'division
        '
        Me.division.AutoSize = True
        Me.division.Location = New System.Drawing.Point(38, 208)
        Me.division.Name = "division"
        Me.division.Size = New System.Drawing.Size(44, 13)
        Me.division.TabIndex = 25
        Me.division.Text = "División"
        '
        'txtmultiplicacion
        '
        Me.txtmultiplicacion.Location = New System.Drawing.Point(115, 174)
        Me.txtmultiplicacion.Name = "txtmultiplicacion"
        Me.txtmultiplicacion.Size = New System.Drawing.Size(100, 20)
        Me.txtmultiplicacion.TabIndex = 24
        '
        'txtResta
        '
        Me.txtResta.Location = New System.Drawing.Point(115, 140)
        Me.txtResta.Name = "txtResta"
        Me.txtResta.Size = New System.Drawing.Size(100, 20)
        Me.txtResta.TabIndex = 23
        '
        'txtSuma
        '
        Me.txtSuma.Location = New System.Drawing.Point(115, 111)
        Me.txtSuma.Name = "txtSuma"
        Me.txtSuma.Size = New System.Drawing.Size(100, 20)
        Me.txtSuma.TabIndex = 22
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(224, 36)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 21
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'multiplicacion
        '
        Me.multiplicacion.AutoSize = True
        Me.multiplicacion.Location = New System.Drawing.Point(38, 177)
        Me.multiplicacion.Name = "multiplicacion"
        Me.multiplicacion.Size = New System.Drawing.Size(71, 13)
        Me.multiplicacion.TabIndex = 20
        Me.multiplicacion.Text = "Multiplicación"
        '
        'resta
        '
        Me.resta.AutoSize = True
        Me.resta.Location = New System.Drawing.Point(41, 143)
        Me.resta.Name = "resta"
        Me.resta.Size = New System.Drawing.Size(35, 13)
        Me.resta.TabIndex = 19
        Me.resta.Text = "Resta"
        '
        'suma
        '
        Me.suma.AutoSize = True
        Me.suma.Location = New System.Drawing.Point(42, 111)
        Me.suma.Name = "suma"
        Me.suma.Size = New System.Drawing.Size(34, 13)
        Me.suma.TabIndex = 18
        Me.suma.Text = "Suma"
        '
        'txtValor2
        '
        Me.txtValor2.Location = New System.Drawing.Point(102, 56)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(100, 20)
        Me.txtValor2.TabIndex = 17
        '
        'txtValor1
        '
        Me.txtValor1.Location = New System.Drawing.Point(102, 23)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(100, 20)
        Me.txtValor1.TabIndex = 16
        '
        'valor2
        '
        Me.valor2.AutoSize = True
        Me.valor2.Location = New System.Drawing.Point(42, 59)
        Me.valor2.Name = "valor2"
        Me.valor2.Size = New System.Drawing.Size(40, 13)
        Me.valor2.TabIndex = 15
        Me.valor2.Text = "Valor 2"
        '
        'valor1
        '
        Me.valor1.AutoSize = True
        Me.valor1.Location = New System.Drawing.Point(42, 26)
        Me.valor1.Name = "valor1"
        Me.valor1.Size = New System.Drawing.Size(40, 13)
        Me.valor1.TabIndex = 14
        Me.valor1.Text = "Valor 1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 346)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtdivision)
        Me.Controls.Add(Me.division)
        Me.Controls.Add(Me.txtmultiplicacion)
        Me.Controls.Add(Me.txtResta)
        Me.Controls.Add(Me.txtSuma)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.multiplicacion)
        Me.Controls.Add(Me.resta)
        Me.Controls.Add(Me.suma)
        Me.Controls.Add(Me.txtValor2)
        Me.Controls.Add(Me.txtValor1)
        Me.Controls.Add(Me.valor2)
        Me.Controls.Add(Me.valor1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents txtdivision As TextBox
    Friend WithEvents division As Label
    Friend WithEvents txtmultiplicacion As TextBox
    Friend WithEvents txtResta As TextBox
    Friend WithEvents txtSuma As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents multiplicacion As Label
    Friend WithEvents resta As Label
    Friend WithEvents suma As Label
    Friend WithEvents txtValor2 As TextBox
    Friend WithEvents txtValor1 As TextBox
    Friend WithEvents valor2 As Label
    Friend WithEvents valor1 As Label
End Class

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
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtValor2 = New System.Windows.Forms.TextBox()
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.checkRaiz = New System.Windows.Forms.CheckBox()
        Me.checkPotencia = New System.Windows.Forms.CheckBox()
        Me.checkDivision = New System.Windows.Forms.CheckBox()
        Me.checkMultiplicacion = New System.Windows.Forms.CheckBox()
        Me.checkResta = New System.Windows.Forms.CheckBox()
        Me.checkSuma = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(223, 277)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(100, 20)
        Me.txtResultado.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(162, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Resultado"
        '
        'txtValor2
        '
        Me.txtValor2.Location = New System.Drawing.Point(315, 53)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(100, 20)
        Me.txtValor2.TabIndex = 25
        '
        'txtValor1
        '
        Me.txtValor1.Location = New System.Drawing.Point(90, 53)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(100, 20)
        Me.txtValor1.TabIndex = 24
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(269, 202)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 23
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(167, 202)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 22
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(269, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Valor 2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Valor 1"
        '
        'checkRaiz
        '
        Me.checkRaiz.AutoSize = True
        Me.checkRaiz.Location = New System.Drawing.Point(368, 155)
        Me.checkRaiz.Name = "checkRaiz"
        Me.checkRaiz.Size = New System.Drawing.Size(47, 17)
        Me.checkRaiz.TabIndex = 19
        Me.checkRaiz.Text = "Raiz"
        Me.checkRaiz.UseVisualStyleBackColor = True
        '
        'checkPotencia
        '
        Me.checkPotencia.AutoSize = True
        Me.checkPotencia.Location = New System.Drawing.Point(368, 117)
        Me.checkPotencia.Name = "checkPotencia"
        Me.checkPotencia.Size = New System.Drawing.Size(68, 17)
        Me.checkPotencia.TabIndex = 18
        Me.checkPotencia.Text = "Potencia"
        Me.checkPotencia.UseVisualStyleBackColor = True
        '
        'checkDivision
        '
        Me.checkDivision.AutoSize = True
        Me.checkDivision.Location = New System.Drawing.Point(205, 155)
        Me.checkDivision.Name = "checkDivision"
        Me.checkDivision.Size = New System.Drawing.Size(63, 17)
        Me.checkDivision.TabIndex = 17
        Me.checkDivision.Text = "División"
        Me.checkDivision.UseVisualStyleBackColor = True
        '
        'checkMultiplicacion
        '
        Me.checkMultiplicacion.AutoSize = True
        Me.checkMultiplicacion.Location = New System.Drawing.Point(205, 117)
        Me.checkMultiplicacion.Name = "checkMultiplicacion"
        Me.checkMultiplicacion.Size = New System.Drawing.Size(90, 17)
        Me.checkMultiplicacion.TabIndex = 16
        Me.checkMultiplicacion.Text = "Multiplicación"
        Me.checkMultiplicacion.UseVisualStyleBackColor = True
        '
        'checkResta
        '
        Me.checkResta.AutoSize = True
        Me.checkResta.Location = New System.Drawing.Point(73, 155)
        Me.checkResta.Name = "checkResta"
        Me.checkResta.Size = New System.Drawing.Size(54, 17)
        Me.checkResta.TabIndex = 15
        Me.checkResta.Text = "Resta"
        Me.checkResta.UseVisualStyleBackColor = True
        '
        'checkSuma
        '
        Me.checkSuma.AutoSize = True
        Me.checkSuma.Location = New System.Drawing.Point(74, 117)
        Me.checkSuma.Name = "checkSuma"
        Me.checkSuma.Size = New System.Drawing.Size(53, 17)
        Me.checkSuma.TabIndex = 14
        Me.checkSuma.Text = "Suma"
        Me.checkSuma.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 341)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtValor2)
        Me.Controls.Add(Me.txtValor1)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.checkRaiz)
        Me.Controls.Add(Me.checkPotencia)
        Me.Controls.Add(Me.checkDivision)
        Me.Controls.Add(Me.checkMultiplicacion)
        Me.Controls.Add(Me.checkResta)
        Me.Controls.Add(Me.checkSuma)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtResultado As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtValor2 As TextBox
    Friend WithEvents txtValor1 As TextBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents checkRaiz As CheckBox
    Friend WithEvents checkPotencia As CheckBox
    Friend WithEvents checkDivision As CheckBox
    Friend WithEvents checkMultiplicacion As CheckBox
    Friend WithEvents checkResta As CheckBox
    Friend WithEvents checkSuma As CheckBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ejercicio2
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
        Me.components = New System.ComponentModel.Container()
        Me.txtValorA = New System.Windows.Forms.TextBox()
        Me.txtValorB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtValorC = New System.Windows.Forms.TextBox()
        Me.txtX1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtX2 = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDiscriminante = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtValorA
        '
        Me.txtValorA.Location = New System.Drawing.Point(147, 57)
        Me.txtValorA.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValorA.Name = "txtValorA"
        Me.txtValorA.Size = New System.Drawing.Size(98, 23)
        Me.txtValorA.TabIndex = 0
        '
        'txtValorB
        '
        Me.txtValorB.Location = New System.Drawing.Point(147, 88)
        Me.txtValorB.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValorB.Name = "txtValorB"
        Me.txtValorB.Size = New System.Drawing.Size(98, 23)
        Me.txtValorB.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 80)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ingrese el valor de a"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Ingrese el valor de b"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Ingrese el valor de c"
        '
        'txtValorC
        '
        Me.txtValorC.Location = New System.Drawing.Point(147, 121)
        Me.txtValorC.Margin = New System.Windows.Forms.Padding(4)
        Me.txtValorC.Name = "txtValorC"
        Me.txtValorC.Size = New System.Drawing.Size(98, 23)
        Me.txtValorC.TabIndex = 6
        '
        'txtX1
        '
        Me.txtX1.Enabled = False
        Me.txtX1.Location = New System.Drawing.Point(52, 263)
        Me.txtX1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtX1.Name = "txtX1"
        Me.txtX1.Size = New System.Drawing.Size(98, 23)
        Me.txtX1.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(221, 269)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "X2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 269)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(25, 17)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "X1"
        '
        'txtX2
        '
        Me.txtX2.Enabled = False
        Me.txtX2.Location = New System.Drawing.Point(252, 263)
        Me.txtX2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtX2.Name = "txtX2"
        Me.txtX2.Size = New System.Drawing.Size(98, 23)
        Me.txtX2.TabIndex = 11
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(274, 60)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 12
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 34)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Forma estandar: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ax^2 + bx + c = 0."
        '
        'txtDiscriminante
        '
        Me.txtDiscriminante.Enabled = False
        Me.txtDiscriminante.Location = New System.Drawing.Point(120, 180)
        Me.txtDiscriminante.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDiscriminante.Name = "txtDiscriminante"
        Me.txtDiscriminante.Size = New System.Drawing.Size(98, 23)
        Me.txtDiscriminante.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 17)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Discriminante: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(128, 225)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(117, 17)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Posibles Soluciones"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(275, 105)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Nuevo"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(45, 318)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(79, 34)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Regresar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ejercicio2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(399, 373)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDiscriminante)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtX2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtX1)
        Me.Controls.Add(Me.txtValorC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtValorB)
        Me.Controls.Add(Me.txtValorA)
        Me.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ejercicio2"
        Me.Text = "Formula General o Cuadratica"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtValorA As TextBox
    Friend WithEvents txtValorB As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtValorC As TextBox
    Friend WithEvents txtX1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtX2 As TextBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDiscriminante As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCiencia = New System.Windows.Forms.Button()
        Me.btnEspañol = New System.Windows.Forms.Button()
        Me.btnMatematicas = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(31, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Matemáticas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Crimson
        Me.Label2.Location = New System.Drawing.Point(394, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Español"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(225, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Ciencia"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(243, 343)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Terminar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnCiencia
        '
        Me.btnCiencia.BackColor = System.Drawing.Color.White
        Me.btnCiencia.BackgroundImage = Global.Proyecto_cuestionario.My.Resources.Resources.ciencia
        Me.btnCiencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCiencia.Location = New System.Drawing.Point(210, 119)
        Me.btnCiencia.Name = "btnCiencia"
        Me.btnCiencia.Size = New System.Drawing.Size(133, 117)
        Me.btnCiencia.TabIndex = 2
        Me.btnCiencia.UseVisualStyleBackColor = False
        '
        'btnEspañol
        '
        Me.btnEspañol.BackColor = System.Drawing.Color.White
        Me.btnEspañol.BackgroundImage = Global.Proyecto_cuestionario.My.Resources.Resources.a_b_c
        Me.btnEspañol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEspañol.Location = New System.Drawing.Point(377, 119)
        Me.btnEspañol.Name = "btnEspañol"
        Me.btnEspañol.Size = New System.Drawing.Size(131, 116)
        Me.btnEspañol.TabIndex = 1
        Me.btnEspañol.UseVisualStyleBackColor = False
        '
        'btnMatematicas
        '
        Me.btnMatematicas.BackColor = System.Drawing.Color.White
        Me.btnMatematicas.BackgroundImage = Global.Proyecto_cuestionario.My.Resources.Resources.calculadora
        Me.btnMatematicas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMatematicas.Location = New System.Drawing.Point(39, 119)
        Me.btnMatematicas.Name = "btnMatematicas"
        Me.btnMatematicas.Size = New System.Drawing.Size(133, 117)
        Me.btnMatematicas.TabIndex = 0
        Me.btnMatematicas.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(556, 432)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCiencia)
        Me.Controls.Add(Me.btnEspañol)
        Me.Controls.Add(Me.btnMatematicas)
        Me.Font = New System.Drawing.Font("Broadway", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Gray
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.Text = "Bienvenido"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMatematicas As Button
    Friend WithEvents btnEspañol As Button
    Friend WithEvents btnCiencia As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class

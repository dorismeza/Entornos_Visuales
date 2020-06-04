<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.respuesta11 = New System.Windows.Forms.PictureBox()
        Me.Cp13 = New System.Windows.Forms.RadioButton()
        Me.Cp12 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cp11 = New System.Windows.Forms.RadioButton()
        Me.preg2 = New System.Windows.Forms.GroupBox()
        Me.respuesta12 = New System.Windows.Forms.PictureBox()
        Me.Cp23 = New System.Windows.Forms.RadioButton()
        Me.Cp22 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cp21 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.respuesta13 = New System.Windows.Forms.PictureBox()
        Me.Cp33 = New System.Windows.Forms.RadioButton()
        Me.Cp32 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Cp31 = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.respuesta14 = New System.Windows.Forms.PictureBox()
        Me.Cp43 = New System.Windows.Forms.RadioButton()
        Me.Cp42 = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cp41 = New System.Windows.Forms.RadioButton()
        Me.Puntuacion = New System.Windows.Forms.Button()
        Me.txtpuntuacion = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.respuesta11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.preg2.SuspendLayout()
        CType(Me.respuesta12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.respuesta13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.respuesta14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.respuesta11)
        Me.GroupBox1.Controls.Add(Me.Cp13)
        Me.GroupBox1.Controls.Add(Me.Cp12)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Cp11)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(29, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(298, 164)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pregunta 1"
        '
        'respuesta11
        '
        Me.respuesta11.Location = New System.Drawing.Point(218, 103)
        Me.respuesta11.Name = "respuesta11"
        Me.respuesta11.Size = New System.Drawing.Size(43, 40)
        Me.respuesta11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.respuesta11.TabIndex = 13
        Me.respuesta11.TabStop = False
        '
        'Cp13
        '
        Me.Cp13.AutoSize = True
        Me.Cp13.Location = New System.Drawing.Point(6, 124)
        Me.Cp13.Name = "Cp13"
        Me.Cp13.Size = New System.Drawing.Size(66, 19)
        Me.Cp13.TabIndex = 3
        Me.Cp13.Text = "Célula"
        Me.Cp13.UseVisualStyleBackColor = True
        '
        'Cp12
        '
        Me.Cp12.AutoSize = True
        Me.Cp12.Location = New System.Drawing.Point(6, 94)
        Me.Cp12.Name = "Cp12"
        Me.Cp12.Size = New System.Drawing.Size(82, 19)
        Me.Cp12.TabIndex = 2
        Me.Cp12.Text = "Partícula"
        Me.Cp12.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "¿Cómo se llama el componente mínimo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " que forma a los seres vivos?"
        '
        'Cp11
        '
        Me.Cp11.AutoSize = True
        Me.Cp11.Location = New System.Drawing.Point(6, 65)
        Me.Cp11.Name = "Cp11"
        Me.Cp11.Size = New System.Drawing.Size(65, 19)
        Me.Cp11.TabIndex = 0
        Me.Cp11.Text = "Tejido"
        Me.Cp11.UseVisualStyleBackColor = True
        '
        'preg2
        '
        Me.preg2.Controls.Add(Me.txtpuntuacion)
        Me.preg2.Controls.Add(Me.respuesta12)
        Me.preg2.Controls.Add(Me.Cp23)
        Me.preg2.Controls.Add(Me.Cp22)
        Me.preg2.Controls.Add(Me.Label2)
        Me.preg2.Controls.Add(Me.Cp21)
        Me.preg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.preg2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.preg2.Location = New System.Drawing.Point(333, 12)
        Me.preg2.Name = "preg2"
        Me.preg2.Size = New System.Drawing.Size(298, 164)
        Me.preg2.TabIndex = 1
        Me.preg2.TabStop = False
        Me.preg2.Text = "Pregunta 2"
        '
        'respuesta12
        '
        Me.respuesta12.Location = New System.Drawing.Point(225, 103)
        Me.respuesta12.Name = "respuesta12"
        Me.respuesta12.Size = New System.Drawing.Size(43, 40)
        Me.respuesta12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.respuesta12.TabIndex = 14
        Me.respuesta12.TabStop = False
        '
        'Cp23
        '
        Me.Cp23.AutoSize = True
        Me.Cp23.Location = New System.Drawing.Point(6, 124)
        Me.Cp23.Name = "Cp23"
        Me.Cp23.Size = New System.Drawing.Size(75, 19)
        Me.Cp23.TabIndex = 3
        Me.Cp23.Text = "Meiosis"
        Me.Cp23.UseVisualStyleBackColor = True
        '
        'Cp22
        '
        Me.Cp22.AutoSize = True
        Me.Cp22.Location = New System.Drawing.Point(6, 94)
        Me.Cp22.Name = "Cp22"
        Me.Cp22.Size = New System.Drawing.Size(71, 19)
        Me.Cp22.TabIndex = 2
        Me.Cp22.Text = "Mitosis"
        Me.Cp22.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(276, 30)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "El proceso por el que una célula se divide" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " para formar dos células hijas se lla" &
    "ma:"
        '
        'Cp21
        '
        Me.Cp21.AutoSize = True
        Me.Cp21.Location = New System.Drawing.Point(6, 65)
        Me.Cp21.Name = "Cp21"
        Me.Cp21.Size = New System.Drawing.Size(106, 19)
        Me.Cp21.TabIndex = 0
        Me.Cp21.Text = "Segregacion"
        Me.Cp21.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.respuesta13)
        Me.GroupBox3.Controls.Add(Me.Cp33)
        Me.GroupBox3.Controls.Add(Me.Cp32)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Cp31)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(29, 202)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(298, 164)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pregunta 3"
        '
        'respuesta13
        '
        Me.respuesta13.Location = New System.Drawing.Point(218, 94)
        Me.respuesta13.Name = "respuesta13"
        Me.respuesta13.Size = New System.Drawing.Size(43, 40)
        Me.respuesta13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.respuesta13.TabIndex = 14
        Me.respuesta13.TabStop = False
        '
        'Cp33
        '
        Me.Cp33.AutoSize = True
        Me.Cp33.Location = New System.Drawing.Point(6, 124)
        Me.Cp33.Name = "Cp33"
        Me.Cp33.Size = New System.Drawing.Size(90, 19)
        Me.Cp33.TabIndex = 3
        Me.Cp33.Text = "Branquias"
        Me.Cp33.UseVisualStyleBackColor = True
        '
        'Cp32
        '
        Me.Cp32.AutoSize = True
        Me.Cp32.Location = New System.Drawing.Point(6, 94)
        Me.Cp32.Name = "Cp32"
        Me.Cp32.Size = New System.Drawing.Size(89, 19)
        Me.Cp32.TabIndex = 2
        Me.Cp32.Text = "Pulmones"
        Me.Cp32.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(205, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "¿Con qué respira una ballena?"
        '
        'Cp31
        '
        Me.Cp31.AutoSize = True
        Me.Cp31.Location = New System.Drawing.Point(6, 65)
        Me.Cp31.Name = "Cp31"
        Me.Cp31.Size = New System.Drawing.Size(91, 19)
        Me.Cp31.TabIndex = 0
        Me.Cp31.Text = "Por la piel"
        Me.Cp31.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.respuesta14)
        Me.GroupBox4.Controls.Add(Me.Cp43)
        Me.GroupBox4.Controls.Add(Me.Cp42)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Cp41)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(333, 202)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(298, 164)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Pregunta 4"
        '
        'respuesta14
        '
        Me.respuesta14.Location = New System.Drawing.Point(225, 103)
        Me.respuesta14.Name = "respuesta14"
        Me.respuesta14.Size = New System.Drawing.Size(43, 40)
        Me.respuesta14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.respuesta14.TabIndex = 14
        Me.respuesta14.TabStop = False
        '
        'Cp43
        '
        Me.Cp43.AutoSize = True
        Me.Cp43.Location = New System.Drawing.Point(6, 124)
        Me.Cp43.Name = "Cp43"
        Me.Cp43.Size = New System.Drawing.Size(93, 19)
        Me.Cp43.TabIndex = 3
        Me.Cp43.Text = "Electrones"
        Me.Cp43.UseVisualStyleBackColor = True
        '
        'Cp42
        '
        Me.Cp42.AutoSize = True
        Me.Cp42.Location = New System.Drawing.Point(6, 94)
        Me.Cp42.Name = "Cp42"
        Me.Cp42.Size = New System.Drawing.Size(82, 19)
        Me.Cp42.TabIndex = 2
        Me.Cp42.Text = "Protones"
        Me.Cp42.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(294, 30)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "¿Cómo se llaman las partículas subatómicas" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " con carga eléctrica negativa?"
        '
        'Cp41
        '
        Me.Cp41.AutoSize = True
        Me.Cp41.Location = New System.Drawing.Point(6, 65)
        Me.Cp41.Name = "Cp41"
        Me.Cp41.Size = New System.Drawing.Size(91, 19)
        Me.Cp41.TabIndex = 0
        Me.Cp41.Text = "Neutrones"
        Me.Cp41.UseVisualStyleBackColor = True
        '
        'Puntuacion
        '
        Me.Puntuacion.Location = New System.Drawing.Point(547, 408)
        Me.Puntuacion.Name = "Puntuacion"
        Me.Puntuacion.Size = New System.Drawing.Size(81, 30)
        Me.Puntuacion.TabIndex = 14
        Me.Puntuacion.Text = "Puntuación"
        Me.Puntuacion.UseVisualStyleBackColor = True
        '
        'txtpuntuacion
        '
        Me.txtpuntuacion.Location = New System.Drawing.Point(241, -10)
        Me.txtpuntuacion.Name = "txtpuntuacion"
        Me.txtpuntuacion.Size = New System.Drawing.Size(59, 21)
        Me.txtpuntuacion.TabIndex = 15
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Puntuacion)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.preg2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form4"
        Me.Text = "Ciencia"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.respuesta11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.preg2.ResumeLayout(False)
        Me.preg2.PerformLayout()
        CType(Me.respuesta12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.respuesta13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.respuesta14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Cp13 As RadioButton
    Friend WithEvents Cp12 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Cp11 As RadioButton
    Friend WithEvents preg2 As GroupBox
    Friend WithEvents Cp23 As RadioButton
    Friend WithEvents Cp22 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Cp21 As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Cp33 As RadioButton
    Friend WithEvents Cp32 As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Cp31 As RadioButton
    Friend WithEvents Cp43 As RadioButton
    Friend WithEvents Cp42 As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Cp41 As RadioButton
    Friend WithEvents respuesta11 As PictureBox
    Friend WithEvents respuesta12 As PictureBox
    Friend WithEvents respuesta13 As PictureBox
    Friend WithEvents respuesta14 As PictureBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Puntuacion As Button
    Friend WithEvents txtpuntuacion As TextBox
End Class

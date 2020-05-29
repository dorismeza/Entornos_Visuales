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
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.cmbEquipos = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(87, 98)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(75, 23)
        Me.btnMostrar.TabIndex = 0
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'cmbEquipos
        '
        Me.cmbEquipos.FormattingEnabled = True
        Me.cmbEquipos.Items.AddRange(New Object() {"Real Madrid", "Man United", "Chealsea", "Totenham", "B.  Dortmund"})
        Me.cmbEquipos.Location = New System.Drawing.Point(63, 55)
        Me.cmbEquipos.Name = "cmbEquipos"
        Me.cmbEquipos.Size = New System.Drawing.Size(121, 21)
        Me.cmbEquipos.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 185)
        Me.Controls.Add(Me.cmbEquipos)
        Me.Controls.Add(Me.btnMostrar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnMostrar As Button
    Friend WithEvents cmbEquipos As ComboBox
End Class

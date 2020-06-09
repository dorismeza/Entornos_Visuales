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
        Me.btnejer1 = New System.Windows.Forms.Button()
        Me.btnejer5 = New System.Windows.Forms.Button()
        Me.btnejer2 = New System.Windows.Forms.Button()
        Me.btnejer4 = New System.Windows.Forms.Button()
        Me.btnejer3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnejer1
        '
        Me.btnejer1.Location = New System.Drawing.Point(36, 40)
        Me.btnejer1.Name = "btnejer1"
        Me.btnejer1.Size = New System.Drawing.Size(87, 74)
        Me.btnejer1.TabIndex = 0
        Me.btnejer1.Text = "Ejercicio 1 "
        Me.btnejer1.UseVisualStyleBackColor = True
        '
        'btnejer5
        '
        Me.btnejer5.Location = New System.Drawing.Point(125, 120)
        Me.btnejer5.Name = "btnejer5"
        Me.btnejer5.Size = New System.Drawing.Size(77, 69)
        Me.btnejer5.TabIndex = 1
        Me.btnejer5.Text = "Ejercicio 5"
        Me.btnejer5.UseVisualStyleBackColor = True
        '
        'btnejer2
        '
        Me.btnejer2.Location = New System.Drawing.Point(200, 40)
        Me.btnejer2.Name = "btnejer2"
        Me.btnejer2.Size = New System.Drawing.Size(83, 74)
        Me.btnejer2.TabIndex = 2
        Me.btnejer2.Text = "Ejercicio 2"
        Me.btnejer2.UseVisualStyleBackColor = True
        '
        'btnejer4
        '
        Me.btnejer4.Location = New System.Drawing.Point(200, 195)
        Me.btnejer4.Name = "btnejer4"
        Me.btnejer4.Size = New System.Drawing.Size(83, 73)
        Me.btnejer4.TabIndex = 3
        Me.btnejer4.Text = "Ejercicio 4"
        Me.btnejer4.UseVisualStyleBackColor = True
        '
        'btnejer3
        '
        Me.btnejer3.Location = New System.Drawing.Point(36, 195)
        Me.btnejer3.Name = "btnejer3"
        Me.btnejer3.Size = New System.Drawing.Size(87, 73)
        Me.btnejer3.TabIndex = 4
        Me.btnejer3.Text = "Ejercicio 3"
        Me.btnejer3.UseVisualStyleBackColor = True
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 314)
        Me.Controls.Add(Me.btnejer3)
        Me.Controls.Add(Me.btnejer4)
        Me.Controls.Add(Me.btnejer2)
        Me.Controls.Add(Me.btnejer5)
        Me.Controls.Add(Me.btnejer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnejer1 As Button
    Friend WithEvents btnejer5 As Button
    Friend WithEvents btnejer2 As Button
    Friend WithEvents btnejer4 As Button
    Friend WithEvents btnejer3 As Button
End Class

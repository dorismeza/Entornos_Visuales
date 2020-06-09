Imports System.ComponentModel

Public Class ejercicio5
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim salario, sueldo As Double
        salario = Val(txtSalario.Text)
        Try
            If Not IsNumeric(txtSalario.Text) Then
                MsgBox("Ingrese una cantidad correcta")
            End If

            If salario > 0.01 And salario <= 165482.06 Then
                sueldo = salario
                txtDeduccion.Text = "Excento"
            ElseIf salario >= 165482.07 And salario <= 252330.81 Then
                sueldo = salario - (salario * 0.15)
                txtDeduccion.Text = "Impuesto del 15% = " & salario * 0.15
            ElseIf salario >= 252330.82 And salario <= 586815.84 Then
                sueldo = salario - (salario * 0.2)
                txtDeduccion.Text = "Impuesto del 20% = " & salario * 0.2
            ElseIf salario >= 586815.85 Then
                sueldo = salario - (salario * 0.25)
                txtDeduccion.Text = "Impuesto del 25% = " & salario * 0.25
            End If
            txtSueldoNeto.Text = sueldo
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSalario.TextChanged

    End Sub

    Private Sub TextBox1_Validating(sender As Object, e As CancelEventArgs) Handles txtSalario.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese una cantidad")
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtSueldoNeto.Clear()
        txtSalario.Clear()
        txtDeduccion.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class

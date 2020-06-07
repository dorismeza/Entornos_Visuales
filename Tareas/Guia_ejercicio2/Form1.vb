Imports System.ComponentModel

Public Class Form1
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim a, b, c, x1, x2, discriminante As Double
        a = Val(txtValorA.Text)
        b = Val(txtValorB.Text)
        c = Val(txtValorC.Text)

        If IsNumeric(txtValorA.Text) And IsNumeric(txtValorB.Text) And IsNumeric(txtValorC.Text) Then
            If a <> 0 Then
                discriminante = b ^ 2 - 4 * a * c

                If discriminante < 0 Then
                    MsgBox("El discriminante es negativo, no hay posibles soluciones reales")

                ElseIf discriminante > 0 Then
                    x1 = ((-(b)) - (discriminante ^ (1 / 2))) / (2 * a)
                    x2 = ((-(b)) + (discriminante ^ (1 / 2))) / (2 * a)
                ElseIf discriminante = 0 Then
                    MsgBox("El discriminante es cero, solo hay una posible solución")
                    x1 = (-(b)) / (2 * a)
                    txtX2.Text = ""

                End If
                txtDiscriminante.Text = discriminante
                txtX1.Text = x1
                txtX2.Text = x2
            Else
                MsgBox("El valor de A no puede ser cero", vbObjectError)
                txtDiscriminante.Clear()
                txtX1.Clear()
                txtX2.Clear()
                txtValorB.Clear()
                txtValorA.Clear()
                txtValorC.Clear()
            End If

        Else
            MsgBox("Ingrese valores correctos", vbObjectError)
            txtDiscriminante.Clear()
            txtX1.Clear()
            txtX2.Clear()
            txtValorB.Clear()
            txtValorA.Clear()
            txtValorC.Clear()
        End If

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub txtValorA_TextChanged(sender As Object, e As EventArgs) Handles txtValorA.TextChanged

    End Sub

    Private Sub txtValorA_Validating(sender As Object, e As CancelEventArgs) Handles txtValorA.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtValorB_TextChanged(sender As Object, e As EventArgs) Handles txtValorB.TextChanged

    End Sub

    Private Sub txtValorB_Validating(sender As Object, e As CancelEventArgs) Handles txtValorB.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub txtValorC_TextChanged(sender As Object, e As EventArgs) Handles txtValorC.TextChanged

    End Sub

    Private Sub txtValorC_Validating(sender As Object, e As CancelEventArgs) Handles txtValorC.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtDiscriminante.Clear()
        txtX1.Clear()
        txtX2.Clear()
        txtValorB.Clear()
        txtValorA.Clear()
        txtValorC.Clear()
    End Sub
End Class

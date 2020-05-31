
Imports System.ComponentModel

Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim num As Integer
        Dim i As Integer

        txtResultado.Text = ""

        If Not IsNumeric(txtNum.Text) Then

            MsgBox("Ingrese un valor correcto", vbObjectError)
            txtNum.Text = ""
        Else
            txtResultado.Enabled = True
            num = Val(txtNum.Text)
            For i = 1 To 10
                txtResultado.Text = txtResultado.Text & num & " x " & i & " = " & (num * i) & vbCrLf
            Next
        End If


    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        txtResultado.Text = ""
        txtNum.Text = ""
        txtResultado.Enabled = False
    End Sub

    Private Sub txtNum_TextChanged(sender As Object, e As EventArgs) Handles txtNum.TextChanged

    End Sub

    Private Sub txtNum_Validating(sender As Object, e As CancelEventArgs) Handles txtNum.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidacion.SetError(sender, "")
        Else
            Me.ErrorValidacion.SetError(sender, "Ingrese un valor")
        End If
    End Sub
End Class

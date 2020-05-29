Public Class Form1
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim num As Integer
        Dim i As Integer

        txtResultado.Text = ""
        If Not IsNumeric(txtNum.Text) Then

            MsgBox("Ingrese un valor correcto")
            txtNum.Text = ""
        ElseIf txtNum.Text > 0 Then
            num = Val(txtNum.Text)
            For i = 1 To 10
                txtResultado.Text = txtResultado.Text & num & " x " & i & " = " & (num * i) & vbCrLf
            Next i
        Else
            MsgBox("Ingrese un valor correcto")
            txtNum.Text = ""
        End If



    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        txtResultado.Text = ""
        txtNum.Text = ""
    End Sub
End Class

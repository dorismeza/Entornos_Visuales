Public Class Form1
    Private Sub validar_Click(sender As Object, e As EventArgs) Handles validar.Click
        Dim valor As Int16

        If txtNumero.Text = "" Then
            MsgBox("Escriba un numero en la casilla", vbInformation)
        ElseIf Not IsNumeric(txtNumero.Text) Then
            MsgBox("Ingrese un valor numerico", vbInformation)
            txtNumero.Text = ""
        ElseIf IsNumeric(valor) Then
            valor = Val(txtNumero.Text)
            If valor = 0 Then
                MsgBox("Numero Cero", vbInformation)
            ElseIf valor > 0 Then
                MsgBox("Numero Positivo")
            ElseIf valor < 0 Then
                MsgBox("Numero Negativo")
            End If
        End If

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtNumero.Clear()
    End Sub
End Class

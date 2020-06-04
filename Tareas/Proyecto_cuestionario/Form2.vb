Imports System.ComponentModel

Public Class Form2
    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Ingresar_Click(sender As Object, e As EventArgs) Handles Ingresar.Click
        Dim nombre As String

        nombre = txtNombre.Text
        If txtNombre.Text = "" Then
            MsgBox("Ingresa un nombre", vbInformation)
        Else
            MessageBox.Show("     Bienvenido  " & nombre, "Cuestionario", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form1.Show()
        End If

    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs)
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        ToolTip.SetToolTip(txtNombre, "Escribe tu nombre")
        ToolTip.ToolTipTitle = "Nombre"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtNombre_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtNombre.MaskInputRejected

    End Sub
End Class
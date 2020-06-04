Imports System.ComponentModel

Public Class Form2

    Private Sub Ingresar_Click(sender As Object, e As EventArgs) Handles Ingresar.Click
        Dim nombre As String

        nombre = txtNombre.Text
        If txtNombre.Text = "" Then
            MsgBox("Ingresa un nombre correcto", vbInformation)
            txtNombre.Text = ""
        ElseIf IsNumeric(txtNombre.Text) Then
            MsgBox("Ingresa un nombre correcto", vbInformation)
            txtNombre.Text = ""
        Else
            MessageBox.Show("     Bienvenido  " & nombre, "Cuestionario", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form1.Show()
        End If

    End Sub


    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        ToolTip.SetToolTip(txtNombre, "Escribe tu nombre")
        ToolTip.ToolTipTitle = "Nombre"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dim cancel As Integer
        Try
            If (MsgBox("¿Esta seguro que desea salir?", vbCritical + vbYesNo) = vbYes) Then
                End
            Else
                cancel = 1
            End If
        Catch ex As Exception
            MsgBox("ex.Message")
        End Try
    End Sub

    Private Sub txtNombre_TextChanged_1(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub
End Class
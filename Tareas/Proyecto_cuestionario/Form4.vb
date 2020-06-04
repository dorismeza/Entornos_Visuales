Public Class Form4
    Private Sub p11_CheckedChanged(sender As Object, e As EventArgs) Handles Cp11.CheckedChanged

        respuesta11.Image = My.Resources.cerrar
        Cp12.Enabled = False
        Cp13.Enabled = False
    End Sub

    Private Sub Cp12_CheckedChanged(sender As Object, e As EventArgs) Handles Cp12.CheckedChanged

        respuesta11.Image = My.Resources.cerrar
        Cp11.Enabled = False
        Cp13.Enabled = False
    End Sub

    Private Sub Cp13_CheckedChanged(sender As Object, e As EventArgs) Handles Cp13.CheckedChanged
        respuesta11.Image = My.Resources.garrapata
        Cp11.Enabled = False
        Cp12.Enabled = False
    End Sub

    Private Sub Cp21_CheckedChanged_1(sender As Object, e As EventArgs) Handles Cp21.CheckedChanged
        respuesta12.Image = My.Resources.cerrar
        Cp22.Enabled = False
        Cp23.Enabled = False
    End Sub

    Private Sub Cp22_CheckedChanged_1(sender As Object, e As EventArgs) Handles Cp22.CheckedChanged
        respuesta12.Image = My.Resources.garrapata
        Cp21.Enabled = False
        Cp23.Enabled = False
    End Sub

    Private Sub Cp23_CheckedChanged_1(sender As Object, e As EventArgs) Handles Cp23.CheckedChanged
        respuesta12.Image = My.Resources.cerrar
        Cp22.Enabled = False
        Cp21.Enabled = False
    End Sub

    Private Sub Cp31_CheckedChanged(sender As Object, e As EventArgs) Handles Cp31.CheckedChanged
        respuesta13.Image = My.Resources.cerrar
        Cp32.Enabled = False
        Cp33.Enabled = False
    End Sub

    Private Sub Mp32_CheckedChanged(sender As Object, e As EventArgs) Handles Cp32.CheckedChanged
        respuesta13.Image = My.Resources.garrapata
        Cp31.Enabled = False
        Cp33.Enabled = False
    End Sub

    Private Sub Cp33_CheckedChanged(sender As Object, e As EventArgs) Handles Cp33.CheckedChanged
        respuesta13.Image = My.Resources.cerrar
        Cp31.Enabled = False
        Cp32.Enabled = False
    End Sub

    Private Sub Cp42_CheckedChanged(sender As Object, e As EventArgs) Handles Cp42.CheckedChanged
        respuesta14.Image = My.Resources.cerrar
        Cp43.Enabled = False
    End Sub

    Private Sub Cp41_CheckedChanged(sender As Object, e As EventArgs) Handles Cp41.CheckedChanged
        respuesta14.Image = My.Resources.cerrar
        Cp42.Enabled = False
        Cp43.Enabled = False
    End Sub

    Private Sub Cp43_CheckedChanged(sender As Object, e As EventArgs) Handles Cp43.CheckedChanged
        respuesta14.Image = My.Resources.garrapata
        Cp41.Enabled = False
        Cp41.Enabled = False
        Cp42.Enabled = False
    End Sub

    Private Sub Puntuacion_Click(sender As Object, e As EventArgs) Handles Puntuacion.Click
        Dim x As Integer
        Cregresar.Enabled = True

        Cregresar.Enabled = False
        If Cp13.Checked = True Then
            x = x + 1
        End If

        If Cp22.Checked = True Then
            x = x + 1
        End If

        If Cp32.Checked = True Then
            x = x + 1
        End If

        If Cp43.Checked = True Then
            x = x + 1
        End If
        MsgBox("Tu puntuacion es " & x & "/4", vbInformation)

        txtpuntuacion.Text = x
        Cregresar.Enabled = True
    End Sub

    Private Sub Eregresar_Click(sender As Object, e As EventArgs) Handles Cregresar.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Tendras un intento para responder el cuestionario, una vez finalizado puedes consultar tu puntuacion", "Ciencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
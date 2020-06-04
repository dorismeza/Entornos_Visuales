Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Tendras un intento para responder el cuestionario, una vez finalizado puedes consultar tu puntuacion", "Matematicas", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub Mp11_CheckedChanged(sender As Object, e As EventArgs) Handles Mp11.CheckedChanged

        respuesta1.Image = My.Resources.garrapata
        Mp12.Enabled = False
        Mp13.Enabled = False
    End Sub

    Private Sub Mp12_CheckedChanged(sender As Object, e As EventArgs) Handles Mp12.CheckedChanged

        respuesta1.Image = My.Resources.cerrar
        Mp11.Enabled = False
        Mp13.Enabled = False
    End Sub

    Private Sub Mp13_CheckedChanged(sender As Object, e As EventArgs) Handles Mp13.CheckedChanged
        respuesta1.Image = My.Resources.cerrar
        Mp11.Enabled = False
        Mp12.Enabled = False
    End Sub

    Private Sub Mp21_CheckedChanged_1(sender As Object, e As EventArgs) Handles Mp21.CheckedChanged
        respuesta2.Image = My.Resources.cerrar
        Mp22.Enabled = False
        Mp23.Enabled = False
    End Sub

    Private Sub Mp22_CheckedChanged_1(sender As Object, e As EventArgs) Handles Mp22.CheckedChanged
        respuesta2.Image = My.Resources.garrapata
        Mp21.Enabled = False
        Mp23.Enabled = False
    End Sub

    Private Sub Mp23_CheckedChanged_1(sender As Object, e As EventArgs) Handles Mp23.CheckedChanged
        respuesta2.Image = My.Resources.cerrar
        Mp22.Enabled = False
        Mp21.Enabled = False
    End Sub

    Private Sub Mp31_CheckedChanged(sender As Object, e As EventArgs) Handles Mp31.CheckedChanged
        respuesta3.Image = My.Resources.cerrar
        Mp32.Enabled = False
        Mp33.Enabled = False
    End Sub

    Private Sub Mp32_CheckedChanged(sender As Object, e As EventArgs) Handles Mp32.CheckedChanged
        respuesta3.Image = My.Resources.garrapata
        Mp31.Enabled = False
        Mp33.Enabled = False
    End Sub

    Private Sub Mp33_CheckedChanged(sender As Object, e As EventArgs) Handles Mp33.CheckedChanged
        respuesta3.Image = My.Resources.cerrar
        Mp31.Enabled = False
        Mp32.Enabled = False
    End Sub

    Private Sub Mp42_CheckedChanged(sender As Object, e As EventArgs) Handles Mp42.CheckedChanged
        respuesta4.Image = My.Resources.garrapata
        Mp41.Enabled = False
        Mp43.Enabled = False
    End Sub

    Private Sub Mp41_CheckedChanged(sender As Object, e As EventArgs) Handles Mp41.CheckedChanged
        respuesta4.Image = My.Resources.cerrar
        Mp42.Enabled = False
        Mp43.Enabled = False
    End Sub

    Private Sub Mp43_CheckedChanged(sender As Object, e As EventArgs) Handles Mp43.CheckedChanged
        respuesta4.Image = My.Resources.cerrar
        Mp41.Enabled = False
        Mp42.Enabled = False
    End Sub

    Private Sub Eobtener_Click(sender As Object, e As EventArgs) Handles Eobtener.Click
        Dim x As Integer

        Mregresar.Enabled = True

        If Mp11.Checked = True Then
            x = x + 1
        End If

        If Mp22.Checked = True Then
            x = x + 1
        End If

        If Mp32.Checked = True Then
            x = x + 1
        End If

        If Mp42.Checked = True Then
            x = x + 1
        End If
        txtpuntua.Text = x

        Mregresar.Enabled = True
    End Sub

    Private Sub Eregresar_Click(sender As Object, e As EventArgs) Handles Mregresar.Click
        Form1.Show()
        Me.Close()

    End Sub
End Class
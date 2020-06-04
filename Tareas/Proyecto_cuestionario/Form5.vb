Public Class Form5
    Private Sub Ep11_CheckedChanged(sender As Object, e As EventArgs) Handles Ep11.CheckedChanged

        respuest1.Image = My.Resources.cerrar
        Ep12.Enabled = False
        Ep13.Enabled = False
    End Sub

    Private Sub Ep12_CheckedChanged(sender As Object, e As EventArgs) Handles Ep12.CheckedChanged

        respuest1.Image = My.Resources.cerrar
        Ep11.Enabled = False
        Ep13.Enabled = False
    End Sub

    Private Sub Ep13_CheckedChanged(sender As Object, e As EventArgs) Handles Ep13.CheckedChanged
        respuest1.Image = My.Resources.garrapata
        Ep11.Enabled = False
        Ep12.Enabled = False
    End Sub

    Private Sub Ep21_CheckedChanged_1(sender As Object, e As EventArgs) Handles Ep21.CheckedChanged
        respuest2.Image = My.Resources.cerrar
        Ep22.Enabled = False
        Ep23.Enabled = False
    End Sub

    Private Sub Ep22_CheckedChanged_1(sender As Object, e As EventArgs) Handles Ep22.CheckedChanged
        respuest2.Image = My.Resources.garrapata
        Ep21.Enabled = False
        Ep23.Enabled = False
    End Sub

    Private Sub Ep23_CheckedChanged_1(sender As Object, e As EventArgs) Handles Ep23.CheckedChanged
        respuest2.Image = My.Resources.cerrar
        Ep22.Enabled = False
        Ep21.Enabled = False
    End Sub

    Private Sub Ep31_CheckedChanged(sender As Object, e As EventArgs) Handles Ep31.CheckedChanged
        respuest3.Image = My.Resources.cerrar
        Ep32.Enabled = False
        Ep33.Enabled = False
    End Sub

    Private Sub Ep32_CheckedChanged(sender As Object, e As EventArgs) Handles Ep32.CheckedChanged
        respuest3.Image = My.Resources.cerrar
        Ep31.Enabled = False
        Ep33.Enabled = False
    End Sub

    Private Sub Ep33_CheckedChanged(sender As Object, e As EventArgs) Handles Ep33.CheckedChanged
        respuest3.Image = My.Resources.garrapata
        Ep31.Enabled = False
        Ep32.Enabled = False
    End Sub

    Private Sub Mp42_CheckedChanged(sender As Object, e As EventArgs) Handles Ep42.CheckedChanged
        respuest4.Image = My.Resources.garrapata
        Ep41.Enabled = False
        Ep43.Enabled = False
    End Sub

    Private Sub Ep41_CheckedChanged(sender As Object, e As EventArgs) Handles Ep41.CheckedChanged
        respuest4.Image = My.Resources.cerrar
        Ep42.Enabled = False
        Ep43.Enabled = False
    End Sub

    Private Sub Ep43_CheckedChanged(sender As Object, e As EventArgs) Handles Ep43.CheckedChanged
        respuest4.Image = My.Resources.cerrar
        Ep41.Enabled = False
        Ep42.Enabled = False
    End Sub

    Private Sub Eobtener_Click(sender As Object, e As EventArgs) Handles Eobtener.Click
        Dim x As Integer
        Eregresar.Enabled = True
        If Ep13.Checked = True Then
            x = x + 1
        End If
        If Ep22.Checked = True Then
            x = x + 1
        End If

        If Ep33.Checked = True Then
            x = x + 1
        End If

        If Ep42.Checked = True Then
            x = x + 1
        End If

        txtPuntuacion.Text = x
        Eregresar.Enabled = True
    End Sub

    Private Sub Eregresar_Click(sender As Object, e As EventArgs) Handles Eregresar.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Tendras un intento para responder el cuestionario, una vez finalizado puedes consultar tu puntuacion", "Español", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
Public Class Form1
    Private Sub btnMatematicas_Click(sender As Object, e As EventArgs) Handles btnMatematicas.Click
        Form3.Show()
        Me.Close()
        Form2.Show()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTerminar.Click
        Dim Cancel As Integer

        Try
            If (MsgBox("¿Esta seguro que desea terminar?", vbCritical + vbYesNo) = vbYes) Then
                End
            Else
                Cancel = 1
            End If
        Catch ex As Exception
            MsgBox("ex.Message")
        End Try

    End Sub

    Private Sub btnCiencia_Click(sender As Object, e As EventArgs) Handles btnCiencia.Click
        Form4.Show()
        Me.Close()

    End Sub

    Private Sub btnEspañol_Click(sender As Object, e As EventArgs) Handles btnEspañol.Click
        Form5.Show()
        Me.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
End Class

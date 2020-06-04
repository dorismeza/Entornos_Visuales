Public Class Form1
    Private Sub btnMatematicas_Click(sender As Object, e As EventArgs) Handles btnMatematicas.Click
        Form3.Show()
        Me.Hide()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTerminar.Click
        Dim respuesta As Integer

        Try
            respuesta = InputBox("Ingrese 1 si desea salir y cualquiero otro numero si desea regresar ", "Entrega de mascarillas")
            If respuesta = 1 Then
                Me.Close()
                Form2.Close()
            End If

        Catch ex As Exception
            MsgBox("ex.Message")
        End Try

    End Sub

    Private Sub btnCiencia_Click(sender As Object, e As EventArgs) Handles btnCiencia.Click
        Form4.Show()
        Me.Hide()

    End Sub

    Private Sub btnEspañol_Click(sender As Object, e As EventArgs) Handles btnEspañol.Click
        Form5.Show()
        Me.Hide()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

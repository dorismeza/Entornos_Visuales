Public Class Form1
    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click

        Try
            Dim precio, total, totalPagar, orden As Integer
            orden = txtOrden.Text
            For i = 1 To orden Step 1
                precio = InputBox("Ingresa el precio del platillo No." & i, "Precio del platillo")
                totalPagar += precio
            Next
            total = totalPagar + precio
            txtTotal.Text = totalPagar
            txtIndividual.Text = total
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtTotal.Clear()
        txtIndividual.Clear()
        txtOrden.Clear()
    End Sub
End Class
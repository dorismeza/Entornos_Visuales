Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Dim itemId As Integer
        Dim itemNombre As Integer

        itemId = cmbEquipos.SelectedIndex
        itemNombre = cmbEquipos.SelectedItem.ToString

        Select Case itemId
            Case 0
                MsgBox(itemNombre)
            Case 1
                MsgBox(itemNombre)
            Case 2
                MsgBox(itemNombre)
            Case 3
                MsgBox(itemNombre)
            Case 4
                MsgBox(itemNombre)
            Case 5
                MsgBox(itemNombre)
            Case Else
                MsgBox("Seleccione un valor correcto")
        End Select
    End Sub
End Class
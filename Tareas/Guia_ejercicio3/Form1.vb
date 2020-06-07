Public Class Form1
    Dim media, mayor, acumulador As Double
    Dim contador, idalmacen, itemalmacen, cantidad As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Una empresa tiene 10 almacenes (cada 1 con su nombre correspondiente) 
        'y necesita crear un algoritmo que lea las ventas mensuales de cada uno de los mismos,
        'calcule la media de ventas mensual de todos los almacenes y obtenga un listado de los almacenes 
        'cuyas ventas mensuales son superiores a la media

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim media, mayor, acumulador, cantidad As Double
        Dim contador, idalmacen, itemalmacen, cant As Integer

        idalmacen = cmbAlmacen.SelectedIndex
        itemalmacen = cmbAlmacen.SelectedItem.ToString
        cant = Val(txtCantventas.Text)

        Try
            For i = 1 To cant Step 1
                cantidad = InputBox("Ingrese vental mensual" & i, & "")


            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Select Case idalmacen
            Case 0

        End Select

    End Sub
    Private Sub Ingreso()

    End Sub
End Class

Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles valor1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtValor1.TextChanged

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim suma As Integer
        Dim resta As Integer
        Dim multiplicacion As Integer
        Dim division As Double

        valor1 = Val(txtValor1.Text)
        valor2 = Val(txtValor2.Text)

        suma = valor1 + valor2
        multiplicacion = valor1 * valor2
        division = valor1 / valor2
        resta = valor1 - valor2

        txtSuma.Text = suma
        txtResta.Text = resta
        txtmultiplicacion.Text = multiplicacion
        txtdivision.Text = division
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub
End Class

Public Class Calculadora
    Dim Operacion As String
    Dim Resultado As Nullable(Of Double) = Nothing
    Dim Valor2 As Nullable(Of Double) = Nothing
    Dim Bandera As Boolean

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        Vaciar()
        txtProceso.Text &= "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        Vaciar()
        txtProceso.Text &= "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        Vaciar()
        txtProceso.Text &= "9"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Vaciar()
        txtProceso.Text &= "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        Vaciar()
        txtProceso.Text &= "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        Vaciar()
        txtProceso.Text &= "6"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Vaciar()
        txtProceso.Text &= "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Vaciar()
        txtProceso.Text &= "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Vaciar()
        txtProceso.Text &= "3"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        Vaciar()
        txtProceso.Text &= "0"
    End Sub

    Private Sub btnPunto_Click(sender As Object, e As EventArgs) Handles btnPunto.Click
        Vaciar()
        If InStr(txtProceso.Text, ".", CompareMethod.Text) = 0 Then
            txtProceso.Text &= "."
        Else
            MsgBox("ERROR")
        End If
    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        Proceso()
        Operacion = "+"
    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        Proceso()
        Operacion = "-"
    End Sub

    Private Sub btnMultiplicacion_Click(sender As Object, e As EventArgs) Handles btnMultiplicacion.Click
        Proceso()
        Operacion = "*"
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        Proceso()
        Operacion = "/"
    End Sub

    Private Sub btnSigno_Click(sender As Object, e As EventArgs) Handles btnSigno.Click

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtProceso.Clear()
        Vaciar()
    End Sub

    Private Sub btnIngual_Click(sender As Object, e As EventArgs) Handles btnIngual.Click
        Vaciar()
        Proceso()
    End Sub

    Public Sub Vaciar()
        If Bandera = True Then
            txtProceso.Text = ""
            Bandera = False
        ElseIf txtProceso.Text = "0" Then
            txtProceso.Text = ""
        End If
    End Sub
    Public Sub Proceso()
        Bandera = True
        Valor2 = Val(txtProceso.Text)

        If Resultado IsNot Nothing Then

                Select Case Operacion
                    Case "+"
                        Resultado = Resultado + Valor2
                    Case "-"
                        Resultado -= Valor2
                    Case "*"
                        Resultado *= Valor2
                    Case "/"
                        Resultado /= Valor2
                End Select
                txtProceso.Text = Resultado
            Else
                Resultado = Valor2
            End If


    End Sub

End Class

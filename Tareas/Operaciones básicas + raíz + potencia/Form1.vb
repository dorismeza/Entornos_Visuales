Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        Dim valor1 As Integer
        Dim valor2 As Integer
        Dim suma As Integer
        Dim resta As Integer
        Dim multiplicacion As Integer
        Dim division As Double
        Dim potencia As Integer
        Dim raiz As Double

        valor1 = Val(txtValor1.Text)
        valor2 = Val(txtValor2.Text)

        If txtValor1.Text = "" Or txtValor2.Text = "" Then
            MsgBox("Ingrese  un valor en la casilla", vbInformation)
            txtResultado.Text = ""
        End If

        If Not IsNumeric(txtValor1.Text) And IsNumeric(txtValor2.Text) Then
            MsgBox("Ingresa un valor numerico")
            txtValor1.Text = ""
            txtValor2.Text = ""
            txtResultado.Text = ""
        Else


            If (checkSuma.Checked = True) Then
                suma = valor1 + valor2
                txtResultado.Text = suma
            End If

            If (checkResta.Checked = True) Then
                resta = valor1 - valor2
                txtResultado.Text = resta
            End If

            If (checkMultiplicacion.Checked = True) Then
                multiplicacion = valor1 * valor2
                txtResultado.Text = multiplicacion
            End If

            If (checkDivision.Checked = True) Then
                If valor2 = 0 Then
                    MsgBox("No se puede dividir por cero")
                ElseIf valor2 <> 0 Then
                    division = valor1 / valor2
                    txtResultado.Text = division
                End If
            End If

            If (checkPotencia.Checked = True) Then
                potencia = valor1 ^ valor2
                txtResultado.Text = potencia
            End If

            If (checkRaiz.Checked = True) Then
                raiz = valor1 ^ (1 / 2)
                txtResultado.Text = raiz
            End If
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtValor1.Clear()
        txtValor2.Clear()
        txtResultado.Clear()
        checkDivision.Checked = False
        checkRaiz.Checked = False
        checkMultiplicacion.Checked = False
        checkPotencia.Checked = False
        checkResta.Checked = False
        checkSuma.Checked = False

    End Sub


End Class
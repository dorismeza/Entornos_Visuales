Imports System.ComponentModel

Public Class ejercicio4
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbNumIngresados.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numero, cantidad, positivos, negativos, pares, impares, total As Integer

        cantidad = Val(txtCantidad.Text)

        Try
            If Not IsNumeric(txtCantidad.Text) Then
                MsgBox("Ingrese un numero")
            End If
            For i = 1 To cantidad Step 1
                numero = InputBox("Ingrese numero " & i, "Ingreso de numeros")
                cmbNumIngresados.Items.Add(numero)
                total += numero
                If numero > 0 Then
                    positivos += 1
                Else
                    negativos += 1
                End If
                If numero Mod 2 = 0 Then
                    pares += 1
                Else
                    impares += 1
                End If
            Next
            txtPares.Text = pares
            txtImpares.Text = impares
            txtNegativos.Text = negativos
            txtPositivos.Text = positivos
            txtTotal.Text = total

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged

    End Sub

    Private Sub txtCantidad_Validating(sender As Object, e As CancelEventArgs) Handles txtCantidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese una cantidad")
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Me.cmbNumIngresados.Items.Clear()
        txtCantidad.Clear()
        txtImpares.Clear()
        txtPares.Clear()
        txtNegativos.Clear()
        txtPositivos.Clear()
        txtTotal.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class

Imports System.ComponentModel

Public Class ejercicio3
    Dim media = 0,
        acumulador,
        cantidad, calcular(20) As Double
    Dim cant As Integer
    Dim itemalmacen, idalmacen As String

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtCantventas.Clear()
        txtlista.Clear()
        txtMedia.Clear()
        cmbAlmacen.Text = ""
        media = 0
        acumulador = 0

    End Sub


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        idalmacen = cmbAlmacen.SelectedIndex
        itemalmacen = cmbAlmacen.SelectedItem
        cant = Val(txtCantventas.Text)

        Try
            If Not IsNumeric(txtCantventas.Text) Then
                MsgBox("Ingrese un valor numerico", vbInformation)
                txtCantventas.Text = ""
            End If

            If cmbAlmacen.Text = "" Then
                MsgBox("Agregue un almacen")
            Else
                Select Case idalmacen
                    Case 0
                        Ingreso()

                    Case 1
                        Ingreso()

                    Case 2
                        Ingreso()

                    Case 3
                        Ingreso()

                    Case 4
                        Ingreso()

                    Case 5
                        Ingreso()
                    Case 6
                        Ingreso()

                    Case 7
                        Ingreso()

                    Case 8
                        Ingreso()

                    Case 9
                        Ingreso()

                End Select

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbAlmacen.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        txtMedia.Text = media
        For j = 1 To 20 Step 1
            If calcular(j) > media Then
                txtlista.Text = txtlista.Text & itemalmacen & " " & calcular(j) & vbCrLf
            End If
        Next
    End Sub
    Private Sub Ingreso()
        Try
            For i = 1 To cant Step 1
                cantidad = InputBox("Ingrese vental mensual " & i, "Ventas Mensuales")
                acumulador += cantidad
                calcular(i) = cantidad
            Next
            media += (acumulador / 10)



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtCantventas_Validating(sender As Object, e As CancelEventArgs) Handles txtCantventas.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Ingrese una cantidad")
        End If
    End Sub
End Class
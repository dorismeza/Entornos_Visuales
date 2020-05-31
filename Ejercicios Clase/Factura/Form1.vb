Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim punitario, cantidad As Integer
        Dim descuento, subtotal, total As Double
        Dim aplidesc As Boolean

        punitario = Val(txtPunitario.Text)
        cantidad = Val(txtCantidad.Text)

        aplidesc = chkDesc.Checked
        descuento = 0
        subtotal = punitario * cantidad

        If aplidesc = True Then
            descuento = subtotal * 0.05
        End If

        total = subtotal - descuento


        'Valida textbox
        If txtPunitario.Text = "" Then
            MsgBox("Casilla vacía, ingrese un valor ", vbInformation)
        ElseIf Not IsNumeric(txtPunitario.Text) Then
            MsgBox("Ingrese un valor numerico", vbInformation)
            txtPunitario.Text = ""
        ElseIf txtPunitario.Text < 0 Then
            MsgBox("Ingrese una cantidad correcta ", vbInformation)
            txtPunitario.Text = ""
        End If

        If txtCantidad.Text = "" Then
            MsgBox("Casilla vacía , ingrese un valor", vbInformation)
        ElseIf Not IsNumeric(txtCantidad.Text) Then
            MsgBox("Ingrese un valor numerico", vbInformation)
            txtCantidad.Text = ""
        ElseIf txtCantidad.Text < 0 Then
            MsgBox("Ingrese una cantidad correcta ", vbInformation)
            txtCantidad.Text = ""
        End If


        txtSubt.Text = subtotal
        txtDescu.Text = descuento
        txtTotal.Text = total

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        txtCantidad.Clear()
        txtDescu.Clear()
        txtPunitario.Clear()
        txtSubt.Clear()
        txtTotal.Clear()

    End Sub
End Class
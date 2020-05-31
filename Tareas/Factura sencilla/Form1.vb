Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim punitario, cantidad, itemIsv, itemDesc As Integer
        Dim descuento, subtotal, total, isv As Double
        Dim aplidesc, aplisv As Boolean

        punitario = Val(txtPunitario.Text)
        cantidad = Val(txtCantidad.Text)
        itemDesc = cmbDesc.SelectedIndex
        itemIsv = cmbIsv.SelectedIndex

        aplidesc = chkDesc.Checked
        aplisv = chkIsv.Checked
        isv = 0
        descuento = 0
        subtotal = punitario * cantidad

        'Calculo de impuesto
        If aplisv = True Then
            If itemIsv = 0 Then
                isv = subtotal * 0.15
            ElseIf itemIsv = 1 Then
                isv = subtotal * 0.17
            ElseIf itemIsv = 3 Then
                MsgBox("Ingrese el impuesto")
            End If
        End If

        If aplidesc = True Then
            If itemDesc = 0 Then
                descuento = subtotal * 0.25
            ElseIf itemDesc = 1 Then
                descuento = subtotal * 0.1
            ElseIf itemDesc = 2 Then
                descuento = subtotal * 0.1
            ElseIf itemDesc = 3 Then
                descuento = subtotal * 0.02
            ElseIf itemDesc = 4 Then
                descuento = subtotal * 0.05
            ElseIf itemDesc = 5 Then
                descuento = subtotal * 0.2
            End If
        End If

        total = subtotal + isv - descuento


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

        txtSubt.Enabled = True
        txtISV.Enabled = True
        txtDescu.Enabled = True
        txtTotal.Enabled = True
        btnNuevo.Enabled = True

        txtSubt.Text = subtotal
        txtDescu.Text = descuento
        txtTotal.Text = total
        txtISV.Text = isv


    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        txtSubt.Enabled = False
        txtISV.Enabled = False
        txtDescu.Enabled = False
        txtTotal.Enabled = False

        txtCantidad.Clear()
        txtDescu.Clear()
        txtISV.Clear()
        txtPunitario.Clear()
        txtSubt.Clear()
        txtTotal.Clear()

        chkDesc.Checked = False
        chkIsv.Checked = False
        cmbDesc.Text = ""
        cmbIsv.Text = ""
        cmbDesc.Enabled = False
        cmbIsv.Enabled = False
        btnNuevo.Enabled = False

    End Sub

    Private Sub chkDesc_CheckedChanged(sender As Object, e As EventArgs) Handles chkDesc.CheckedChanged


        If chkDesc.Checked = True Then
            chkIsv.Enabled = False
            cmbIsv.Enabled = False
            cmbDesc.Enabled = True
        End If

        If chkDesc.Checked = False Then
            chkIsv.Enabled = True
            cmbIsv.Enabled = False
            cmbDesc.Enabled = False
        End If


    End Sub

    Private Sub chkIsv_CheckedChanged(sender As Object, e As EventArgs) Handles chkIsv.CheckedChanged

        If chkIsv.Checked = True Then
            chkDesc.Enabled = False
            cmbDesc.Enabled = False
            cmbIsv.Enabled = True
        End If

        If chkIsv.Checked = False Then
            chkDesc.Enabled = True
            cmbDesc.Enabled = False
            cmbIsv.Enabled = False
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class


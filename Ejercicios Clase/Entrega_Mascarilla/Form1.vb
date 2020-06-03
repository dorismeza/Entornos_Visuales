Imports System.ComponentModel

Public Class Form1
    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click
        'For, DoWhile
        Dim departamentos, mascarillas As Integer
        departamentos = Val(txtDepartamentos.Text)

        If Not IsNumeric(txtDepartamentos.Text) Then
            MsgBox("Ingrese un valor numerico", vbInformation)
            txtDepartamentos.Text = ""
        End If

        If departamentos > 0 And departamentos <= 18 Then
            Try
                For i = 1 To departamentos Step 1
                    Do
                        mascarillas = InputBox("Ingrese la cantidad de mascarillas " & i, ", Ingresar")
                    Loop While (mascarillas < 0 Or mascarillas > 10000)
                    cmbDepartamento.Items.Add(mascarillas)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


        Else
            MsgBox("Numero de departamento incorrecto")
            txtDepartamentos.Text = ""

        End If


    End Sub

    Private Sub entregaMascarillas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbDepartamento.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub btnEntregar_Click(sender As Object, e As EventArgs) Handles btnEntregar.Click
        Dim idDepartamento, municipios, cantEntrega As Integer
        Dim itemDepartamento As Integer

        idDepartamento = cmbDepartamento.SelectedIndex
        itemDepartamento = cmbDepartamento.SelectedItem.ToString
        municipios = txtMunicipios.Text


        If Not IsNumeric(txtMunicipios.Text) Then
            MsgBox("Ingrese un valor numerico", vbInformation)
            txtMunicipios.Text = ""
        End If


        Casos(idDepartamento, municipios, cantEntrega, itemDepartamento)

        txtStock.Text = itemDepartamento



    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Public Function Casos(idD As Integer, muni As Integer, canEntrega As Integer, itemD As Integer)
        Dim cont As Integer

        Select Case idD
            Case 0
                Try
                    For i = 1 To muni Step 1
                        While (itemD > 0)
                            canEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                            If (itemD > canEntrega) Then
                                muni += 1
                                itemD -= canEntrega
                                txtStock.Text = itemD
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case 1
                Try
                    For i = 1 To muni Step 1
                        While (itemD > 0)
                            canEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                            If (itemD > canEntrega) Then
                                muni += 1
                                itemD -= canEntrega
                                txtStock.Text = itemD
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            Case 2
                Try
                    For i = 1 To muni Step 1
                        While (itemD > 0)
                            canEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                            If (itemD > canEntrega) Then
                                muni += 1
                                itemD -= canEntrega
                                txtStock.Text = itemD
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            Case 3
                Try
                    For i = 1 To muni Step 1
                        While (itemD > 0)
                            canEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                            If (itemD > canEntrega) Then
                                muni += 1
                                itemD -= canEntrega
                                txtStock.Text = itemD
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            Case 4
                Try
                    For i = 1 To muni Step 1
                        While (itemD > 0)
                            canEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                            If (itemD > canEntrega) Then
                                muni += 1
                                itemD -= canEntrega
                                txtStock.Text = itemD
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case 5
                Try
                    For i = 1 To muni Step 1
                        While (itemD > 0)
                            canEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                            If (itemD > canEntrega) Then
                                muni += 1
                                itemD -= canEntrega
                                txtStock.Text = itemD
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            Case 6
                Try
                    For i = 1 To muni Step 1
                        While (itemD > 0)
                            canEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                            If (itemD > canEntrega) Then
                                muni += 1
                                itemD -= canEntrega
                                txtStock.Text = itemD
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            Case 7
                Try
                    For i = 1 To muni Step 1
                        While (itemD > 0)
                            canEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                            If (itemD > canEntrega) Then
                                muni += 1
                                itemD -= canEntrega
                                txtStock.Text = itemD
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case 8
                Try
                    For i = 1 To muni Step 1
                        While (itemD > 0)
                            canEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                            If (itemD > canEntrega) Then
                                muni += 1
                                itemD -= canEntrega
                                txtStock.Text = itemD
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            Case 9
                Try
                    For i = 1 To muni Step 1
                        While (itemD > 0)
                            canEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                            If (itemD > canEntrega) Then
                                muni += 1
                                itemD -= canEntrega
                                txtStock.Text = itemD
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            Case 10
                Try
                    For i = 1 To muni Step 1
                        While (itemD > 0)
                            canEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                            If (itemD > canEntrega) Then
                                muni += 1
                                itemD -= canEntrega
                                txtStock.Text = itemD
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            Case 11
                Try
                    For i = 1 To muni Step 1
                        While (itemD > 0)
                            canEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                            If (itemD > canEntrega) Then
                                muni += 1
                                itemD -= canEntrega
                                txtStock.Text = itemD
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            Case 12
                Try
                    For i = 1 To muni Step 1
                        While (itemD > 0)
                            canEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                            If (itemD > canEntrega) Then
                                muni += 1
                                itemD -= canEntrega
                                txtStock.Text = itemD
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            Case 13
                Try
                    For i = 1 To muni Step 1
                        While (itemD > 0)
                            canEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                            If (itemD > canEntrega) Then
                                muni += 1
                                itemD -= canEntrega
                                txtStock.Text = itemD
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            Case 14
                Try
                    For i = 1 To muni Step 1
                        While (itemD > 0)
                            canEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                            If (itemD > canEntrega) Then
                                muni += 1
                                itemD -= canEntrega
                                txtStock.Text = itemD
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case 15
                Try
                    For i = 1 To muni Step 1
                        While (itemD > 0)
                            canEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                            If (itemD > canEntrega) Then
                                muni += 1
                                itemD -= canEntrega
                                txtStock.Text = itemD
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            Case 16
                Try
                    For i = 1 To muni Step 1
                        While (itemD > 0)
                            canEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                            If (itemD > canEntrega) Then
                                muni += 1
                                itemD -= canEntrega
                                txtStock.Text = itemD
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            Case 17
                Try
                    For i = 1 To muni Step 1
                        While (itemD > 0)
                            canEntrega = InputBox("Ingrese la cantidad a entregar", "Entrega de mascarillas")
                            If (itemD > canEntrega) Then
                                muni += 1
                                itemD -= canEntrega
                                txtStock.Text = itemD
                            Else
                                MessageBox.Show("No hay suficientes mascarillas", "Error de entrega", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If
                        End While
                    Next

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

        End Select

        Return itemD
    End Function

    Private Sub txtMunicipios_TextChanged(sender As Object, e As EventArgs) Handles txtMunicipios.TextChanged

    End Sub

    Private Sub txtMunicipios_Validating(sender As Object, e As CancelEventArgs) Handles txtMunicipios.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Ingrese una cantidad")
        End If
    End Sub
End Class
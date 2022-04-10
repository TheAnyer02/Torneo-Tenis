Public Class Main
    Private j As Jugadora
    Private p As Pais

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '---------Actualizar jugadoras---------
        Dim pAux As Jugadora
        Me.j = New Jugadora
        Try
            Me.j.LeerTodasJugadoras()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        For Each pAux In Me.j.PerDAO.Jugadoras
            Me.ListJugadoras.Items.Add(pAux)
        Next
        BTNAñadirJUG.Enabled = True
        '--------Actualizar paises--------------'
        Dim paisAux As Pais
        Me.p = New Pais
        Try
            Me.p.LeerTodosPaises()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        For Each paisAux In Me.p.PerDAO.Paises
            Me.LSTPais.Items.Add(paisAux)
        Next
        BTNAñadirPais.Enabled = True
    End Sub
    '-------------------------------Pestaña jugadoras
    Private Sub ListJugadoras_SelectedTextChanged() Handles ListJugadoras.SelectedIndexChanged
        Me.BTNActualizarJUG.Enabled = True
        Me.BTNEliminarJUG.Enabled = True
        Me.TXTNombreJUG.Enabled = False
        If Not Me.ListJugadoras.SelectedItem Is Nothing Then
            Me.j = New Jugadora(Me.ListJugadoras.SelectedItem.ToString)
            Try
                Me.j.LeerJugadora()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.TXTNombreJUG.Text = Me.j.Nombre.ToString
            Me.TXTPaisJUG.Text = Me.j.Pais.ToString
            Me.DateJugadora.Text = Me.j.Fecha.ToString
        End If
    End Sub
    Private Sub BTNAñadirJUG_Click(sender As Object, e As EventArgs) Handles BTNAñadirJUG.Click
        If Me.TXTNombreJUG.Text <> String.Empty And Me.DateJugadora.Text <> String.Empty And Me.TXTPaisJUG.Text <> String.Empty Then
            j = New Jugadora
            j.Nombre = TXTNombreJUG.Text
            j.Fecha = DateJugadora.Text
            j.Pais = New Pais(TXTNombrePais.Text)

            Try
                If j.InsertarJugadora <> 1 Then
                    MessageBox.Show("INSERT return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.ListJugadoras.Items.Add(j.IDJugadora)
        End If
    End Sub

    Private Sub BtnActualizarJUG_Click(sender As Object, e As EventArgs) Handles BTNActualizarJUG.Click
        If Not j Is Nothing Then
            j.Nombre = TXTNombreJUG.Text
            j.Fecha = DateJugadora.Text
            j.Pais = New Pais(TXTNombrePais.Text)
            Try
                If j.ActualizarJugadora() <> 1 Then
                    MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            MessageBox.Show(j.Nombre & "Actualizado correctamente.")
        End If
    End Sub


    Private Sub BtnEliminarJUG_Click(sender As Object, e As EventArgs) Handles BTNEliminarJUG.Click
        If Not Me.j Is Nothing Then
            If MessageBox.Show("¿Estas seguro que quieres borrar " & Me.j.Nombre & "?", "Por favor confirma.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    If Me.j.BorrarJugadora() <> 1 Then
                        MessageBox.Show("DELETE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try
                Me.ListJugadoras.Items.Remove(j.IDJugadora)
            End If
            Me.BTNLimpiarJUG.PerformClick()
        End If
    End Sub
    Private Sub BtnLimpiarJUG_Click(sender As Object, e As EventArgs) Handles BTNLimpiarJUG.Click
        Me.TXTNombreJUG.Text = String.Empty
        Me.DateJugadora.Text = String.Empty
        Me.TXTPaisJUG.Text = String.Empty
        Me.BTNActualizarJUG.Enabled = False
        Me.BTNEliminarJUG.Enabled = False
    End Sub
    '-------------------------------Pestaña Paises
    Private Sub LSTPais_SelectedTextChanged() Handles LSTPais.SelectedIndexChanged
        Me.BTNActualizarPais.Enabled = True
        Me.BTNEliminarPais.Enabled = True
        Me.TXTNombrePais.Enabled = False
        If Not Me.LSTPais.SelectedItem Is Nothing Then
            Me.p = New Pais(Me.LSTPais.SelectedItem.ToString)
            Try
                Me.p.LeerPaises()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.TXTNombrePais.Text = Me.p.NombrePais
        End If
    End Sub
    Private Sub BTNAñadirPais_Click(sender As Object, e As EventArgs) Handles BTNAñadirPais.Click
        If Me.TXTNombrePais.Text <> String.Empty And Me.IDPAIS.Text <> String.Empty Then
            p = New Pais
            p.NombrePais = TXTNombreJUG.Text
            p.idPais = IDPAIS.Text

            Try
                If p.InsertarPais <> 1 Then
                    MessageBox.Show("INSERT return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.LSTPais.Items.Add(p.idPais)
        End If
    End Sub

    Private Sub BTNActualizarPais_Click(sender As Object, e As EventArgs) Handles BTNActualizarPais.Click
        If Not j Is Nothing Then
            j.Nombre = TXTNombreJUG.Text
            p.idPais = IDPAIS.Text
            Try
                If p.InsertarPais <> 1 Then
                    MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            MessageBox.Show(p.NombrePais & " Actualizado correctamente.")
        End If
    End Sub


    Private Sub BTNEliminarPais_Click(sender As Object, e As EventArgs) Handles BTNEliminarPais.Click
        If Not Me.p Is Nothing Then
            If MessageBox.Show("¿Estas seguro que quieres borrar " & Me.p.NombrePais & "?", "Por favor confirma.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    If Me.p.BorrarPais() <> 1 Then
                        MessageBox.Show("DELETE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try
                Me.LSTPais.Items.Remove(p.idPais)
            End If
            Me.BTNLimpiarPais.PerformClick()
        End If
    End Sub
    Private Sub BtnLimpiarPais_Click(sender As Object, e As EventArgs) Handles BTNLimpiarPais.Click
        Me.TXTNombrePais.Text = String.Empty
        Me.BTNActualizarPais.Enabled = False
        Me.BTNEliminarPais.Enabled = False
    End Sub


End Class

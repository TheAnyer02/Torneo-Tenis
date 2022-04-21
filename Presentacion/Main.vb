Imports System.Globalization

Public Class Main
    Private j As Jugadora
    Private p As Pais
    Private t As Torneo

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarJugadoras()
        CargarPaises()
    End Sub
    '-------------------------------Pestaña jugadoras
    Private Sub CargarJugadoras()
        '---------Actualizar jugadoras---------
        Dim pAux As Jugadora
        Me.j = New Jugadora
        Try
            Me.j.LeerTodasJugadoras()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        For Each pAux In Me.j.PerDAO.Jugadoras
            Me.ListJugadoras.Items.Add(pAux.IDJugadora)
        Next
        BTNAñadirJUG.Enabled = True
    End Sub
    Private Sub CargarPaises()
        '--------Actualizar paises--------------'
        Dim paisAux As Pais
        Me.p = New Pais
        Try
            Me.p.LeerTodosPaises()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        For Each paisAux In Me.p.PerDAO.Paises
            Me.LSTPais.Items.Add(paisAux.idPais)
        Next
        BTNAñadirPais.Enabled = True
    End Sub
    Private Sub CargarTorneos()
        Dim torneoAux As Torneo
        Me.t = New Torneo
        Try
            Me.t.LeerTodosTorneos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        For Each torneoAux In Me.t.PerDAO.Torneo
            Me.LSTPais.Items.Add(torneoAux.idTorneo)
        Next
        BTNAñadirPais.Enabled = True
    End Sub
    Private Sub ListJugadoras_SelectedTextChanged() Handles ListJugadoras.SelectedIndexChanged
        If Not Me.ListJugadoras.SelectedItem Is Nothing Then
            Me.j = New Jugadora(Me.ListJugadoras.SelectedItem.ToString)
            Try
                Me.j.LeerJugadora()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try

            Me.TXTNombreJUG.Text = Me.j.Nombre.ToString
            Me.TXTPaisJUG.Text = Me.j.Pais.idPais.ToString
            Me.DateJugadora.Text = Me.j.Fecha.ToString
        End If
    End Sub
    Private Sub BTNAñadirJUG_Click(sender As Object, e As EventArgs) Handles BTNAñadirJUG.Click
        If Me.TXTNombreJUG.Text <> String.Empty And Me.DateJugadora.Text <> String.Empty And Me.TXTPaisJUG.Text <> String.Empty Then
            j = New Jugadora()
            j.Nombre = TXTNombreJUG.Text
            j.Pais = New Pais(TXTPaisJUG.Text)
            j.Fecha = DateJugadora.Text
            Try
                If j.InsertarJugadora <> 1 Then
                    MessageBox.Show("INSERT return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            ListJugadoras.Items.Clear()
            CargarJugadoras()
            TXTNombreJUG.Clear()
            TXTPaisJUG.Clear()
            DateJugadora.Refresh()
        End If
    End Sub

    Private Sub BtnActualizarJUG_Click(sender As Object, e As EventArgs) Handles BTNActualizarJUG.Click
        If Not j Is Nothing Then
            j.Nombre = TXTNombreJUG.Text
            j.Fecha = DateJugadora.Text
            j.Pais = New Pais(TXTPaisJUG.Text)
            Try
                If j.ActualizarJugadora() <> 1 Then
                    MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            MessageBox.Show(j.Nombre & " -> Actualizado correctamente.")
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
    End Sub
    '-------------------------------Pestaña Paises
    Private Sub LSTPais_SelectedTextChanged() Handles LSTPais.SelectedIndexChanged
        If Not Me.LSTPais.SelectedItem Is Nothing Then
            Me.p = New Pais(Me.LSTPais.SelectedItem.ToString)
            Try
                Me.p.LeerPaises()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.TXTNombrePais.Text = Me.p.NombrePais
            Me.IDPAIS.Text = Me.p.idPais
        End If
    End Sub
    Private Sub BTNAñadirPais_Click(sender As Object, e As EventArgs) Handles BTNAñadirPais.Click
        If Me.TXTNombrePais.Text <> String.Empty And Me.IDPAIS.Text <> String.Empty Then
            p = New Pais()
            p.idPais = IDPAIS.Text
            p.NombrePais = TXTNombrePais.Text

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
        If Not p Is Nothing Then
            p.NombrePais = TXTNombrePais.Text
            p.idPais = IDPAIS.Text
            Try
                If p.ActualizarPais <> 1 Then
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
        Me.IDPAIS.Text = String.Empty
    End Sub
    Private Sub BTNAñadirTorneo_Click(sender As Object, e As EventArgs) Handles BTNAñadirTorneo.Click
        If Me.TXTNombreTorneo.Text <> String.Empty And Me.TXTIdTorneo.Text <> String.Empty And Me.TXTCiudadTorneo.Text <> String.Empty And Me.TXTPaisTorneo.Text <> String.Empty Then
            t = New Torneo()
            t.idTorneo = TXTIdTorneo.Text
            t.NombreTorneo = TXTNombreTorneo.Text
            t.CiudadTorneo = TXTCiudadTorneo.Text
            t.PaisTorneo = New Pais(TXTPaisTorneo.Text)

            Try
                If t.InsertarTorneo() <> 1 Then
                    MessageBox.Show("INSERT return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            Me.LSTTorneos.Items.Add(t.idTorneo)
            CargarTorneos()
        End If
    End Sub

    Private Sub BTNEliminarTorneo_Click(sender As Object, e As EventArgs) Handles BTNEliminarTorneo.Click
        If Not Me.t Is Nothing Then
            If MessageBox.Show("¿Estas seguro que quieres borrar " & Me.t.NombreTorneo & "?", "Por favor confirma.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    If Me.t.BorrarTorneo() <> 1 Then
                        MessageBox.Show("DELETE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End Try
                Me.ListJugadoras.Items.Remove(t.idTorneo)
            End If
            Me.BTNLimpiarJUG.PerformClick()
        End If
    End Sub

    Private Sub BTNActualizarTorneo_Click(sender As Object, e As EventArgs) Handles BTNActualizarTorneo.Click
        If Not t Is Nothing Then
            t.NombreTorneo = TXTNombreTorneo.Text
            t.CiudadTorneo = TXTCiudadTorneo.Text
            t.PaisTorneo = New Pais(TXTPaisTorneo.Text)
            Try
                If t.ActualizarTorneo() <> 1 Then
                    MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try
            MessageBox.Show(j.Nombre & " -> Actualizado correctamente.")
        End If
    End Sub

    Private Sub BTNLimpiarTorneo_Click(sender As Object, e As EventArgs) Handles BTNLimpiarTorneo.Click
        Me.TXTIdTorneo.Text = String.Empty
        Me.TXTNombreTorneo.Text = String.Empty
        Me.TXTPaisTorneo.Text = String.Empty
        Me.TXTCiudadTorneo.Text = String.Empty

    End Sub
End Class

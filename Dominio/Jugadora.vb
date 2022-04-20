Public Class Jugadora

    Public Property IDJugadora As Int16
    Public Property Nombre As String
    Public Property Fecha As String
    Public Property Puntos As Int16
    Public Property Pais As Pais
    Public ReadOnly Property PerDAO As JugadoraDAO

    Public Sub New()
        Me.PerDAO = New JugadoraDAO
    End Sub

    Public Sub New(id As Int16)
        Me.PerDAO = New JugadoraDAO
        Me.IDJugadora = id
        Me.Puntos = 0
    End Sub

    Public Sub LeerTodasJugadoras()
        Me.PerDAO.LeerTodas()
    End Sub

    Public Sub LeerJugadora()
        Me.PerDAO.Leer(Me)
    End Sub
    Public Function ObtenerPais()
        Return Me.Pais.idPais
    End Function
    Public Function InsertarJugadora() As Integer
        Return Me.PerDAO.Insertar(Me)
    End Function

    Public Function ActualizarJugadora() As Integer
        Return Me.PerDAO.Actualizar(Me)
    End Function

    Public Function BorrarJugadora() As Integer
        Return Me.PerDAO.Borrar(Me)
    End Function

End Class
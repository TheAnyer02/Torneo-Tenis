Public Class Torneo

    Public Property idTorneo As Int16
    Public Property NombreTorneo As String
    Public Property CiudadTorneo As String
    Public Property PaisTorneo As Char
    Public ReadOnly Property PerDAO As TorneoDAO

    Public Sub New()
        Me.PerDAO = New TorneoDAO
    End Sub

    Public Sub New(id As String)
        Me.PerDAO = New TorneoDAO
        Me.idTorneo = id
    End Sub

    Public Sub LeerTodosTorneos()
        Me.PerDAO.LeerTodas()
    End Sub

    Public Sub LeerTorneo()
        Me.PerDAO.Leer(Me)
    End Sub

    Public Function InsertarTorneo() As Integer
        Return Me.PerDAO.Insertar(Me)
    End Function

    Public Function ActualizarTorneo() As Integer
        Return Me.PerDAO.Actualizar(Me)
    End Function

    Public Function BorrarTorneo() As Integer
        Return Me.PerDAO.Borrar(Me)
    End Function

End Class

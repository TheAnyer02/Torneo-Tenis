Public Class TorneoDAO
    Public ReadOnly Property Torneo As Collection

    Public Sub New()
        Me.Torneo = New Collection
    End Sub

  Public Class TorneoDAO
    Public ReadOnly Property Torneo As Collection

    Public Sub New()
        Me.Torneo = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim t As Torneo
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Torneos ORDER BY idTorneo")
        For Each aux In col
            t = New Torneo(aux(1).ToString)
            t.NombreTorneo = aux(2).ToString
            t.CiudadTorneo = aux(3).ToString
            t.PaisTorneo = New Pais(aux(4).ToString)
            Me.Torneo.Add(t)
        Next
    End Sub

    Public Sub Leer(ByRef t As Torneo)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Torneos WHERE idTorneo='" & t.idTorneo & "';")
        For Each aux In col
            t.NombreTorneo = aux(2).ToString
        Next
    End Sub

    Public Function Insertar(ByVal t As Torneo) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Torneos VALUES ('" & t.idTorneo & "', '" & t.NombreTorneo & "', '" & t.CiudadTorneo & "', '" & t.PaisTorneo.idPais & "');")
    End Function

    Public Function Actualizar(ByVal t As Torneo) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Torneos SET NombreTorneo='" & t.NombreTorneo & "',  CiudadTorneo='" & t.NombreTorneo & "', PaisTorneo='" & t.PaisTorneo.idPais & "' WHERE idTorneo='" & t.idTorneo & "';")
    End Function

    Public Function Borrar(ByVal t As Torneo) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Torneos WHERE idTorneo='" & t.idTorneo & "';")
    End Function
End Class

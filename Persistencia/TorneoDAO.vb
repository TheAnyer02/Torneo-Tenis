Public Class TorneoDAO
    Public ReadOnly Property Torneo As Collection

    Public Sub New()
        Me.Torneo = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim p As Torneo
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Torneos ORDER BY idTorneo")
        For Each aux In col
            p = New Torneo(aux(1).ToString)
            p.NombreTorneo = aux(2).ToString
            p.CiudadTorneo = aux(3).ToString
            p.PaisTorneo.idPais = aux(4).ToString
            Me.Torneo.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As Torneo)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Torneos WHERE idTorneo='" & p.idTorneo & "';")
        For Each aux In col
            p.NombreTorneo = aux(2).ToString
        Next
    End Sub

    Public Function Insertar(ByVal p As Torneo) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Torneos VALUES ('" & p.idTorneo & "', '" & p.NombreTorneo & "','" & p.CiudadTorneo & "', '" & p.PaisTorneo.idPais & "';")
    End Function

    Public Function Actualizar(ByVal p As Torneo) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Torneos SET NombreTorneo='" & p.NombreTorneo & "',  CiudadTorneo='" & p.NombreTorneo & "', PaisTorneo='" & p.PaisTorneo.idPais & "' WHERE idTorneo='" & p.idTorneo & "';")
    End Function

    Public Function Borrar(ByVal p As Torneo) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Torneos WHERE idTorneo='" & p.idTorneo & "';")
    End Function
End Class
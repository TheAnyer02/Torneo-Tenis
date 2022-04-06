Public Class PaisesDAO
    Public ReadOnly Property Paises As Collection

    Public Sub New()
        Me.Paises = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim p As Paises
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Paises ORDER BY idPais")
        For Each aux In col
            p = New Paises(aux(1).ToString)
            p.NombrePais = aux(2).ToString
            Me.Paises.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As Paises)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Paises WHERE idPais='" & p.idPais & "';")
        For Each aux In col
            p.NombrePais = aux(2).ToString
        Next
    End Sub

    Public Function Insertar(ByVal p As Paises) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Torneos VALUES ('" & p.idPais & "', '" & p.NombrePais & "';")
    End Function

    Public Function Actualizar(ByVal p As Paises) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Torneos SET NombrePais='" & p.NombrePais & "' WHERE idPais='" & p.idPais & "';")
    End Function

    Public Function Borrar(ByVal p As Torneo) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Torneos WHERE idTorneo='" & p.idTorneo & "';")
    End Function
End Class

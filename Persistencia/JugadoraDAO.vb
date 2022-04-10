Public Class JugadoraDAO

    Public ReadOnly Property Jugadoras As Collection

    Public Sub New()
        Me.Jugadoras = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim p As Jugadora
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Jugadoras ORDER BY idJugadora")
        For Each aux In col
            p = New Jugadora(aux(1).ToString)
            p.Nombre = aux(2).ToString
            p.Fecha = aux(3).ToString
            p.Puntos = aux(4).ToString
            p.Pais.idPais = aux(5).ToString
            Me.Jugadoras.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As Jugadora)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Jugadoras WHERE idJugadora='" & p.IDJugadora & "';")
        For Each aux In col
            p.Nombre = aux(2).ToString
        Next
    End Sub

    Public Function Insertar(ByVal p As Jugadora) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Jugadoras VALUES ('" & p.IDJugadora & "', '" & p.Nombre & "', '" & p.Fecha & "',
        '" & p.Puntos & "', '" & p.Pais.idPais & "');")
    End Function

    Public Function Actualizar(ByVal p As Jugadora) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Jugadoras SET NombreJugadora='" & p.Nombre & "',  FechaNacimientoJugadora='" & p.Fecha & "', PuntosJugadora='" & p.Puntos & "', PaisJugadora='" & p.Pais.idPais & "' WHERE idJugadora='" & p.IDJugadora & "');")
    End Function

    Public Function Borrar(ByVal p As Jugadora) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Jugadoras WHERE idJugadora='" & p.IDJugadora & "';")
    End Function

End Class
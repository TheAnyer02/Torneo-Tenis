Public Class Pais

    Public Property idPais As Char
    Public Property NombrePais As String

    Public ReadOnly Property PerDAO As PaisesDAO

    Public Sub New()
        Me.PerDAO = New PaisesDAO
    End Sub

    Public Sub New(id As String)
        Me.PerDAO = New PaisesDAO
        Me.idPais = id
    End Sub


    Public Sub LeerTodosPaises()
        Me.PerDAO.LeerTodas()
    End Sub

    Public Sub LeerPaises()
        Me.PerDAO.Leer(Me)
    End Sub

    Public Function InsertarPais() As Integer
        Return Me.PerDAO.Insertar(Me)
    End Function

    Public Function ActualizarPais() As Integer
        Return Me.PerDAO.Actualizar(Me)
    End Function

    Public Function BorrarPais() As Integer
        Return Me.PerDAO.Borrar(Me)
    End Function
    Public Function getNombre() As Integer
        Return Me.NombrePais
    End Function
End Class
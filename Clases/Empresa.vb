Public NotInheritable Class Empresa
    Inherits Propietario
    Private _cuit As String

    Public Property CUIT As String
        Get
            Return _cuit
        End Get
        Set(value As String)
            _cuit = value
        End Set
    End Property

    Sub New(nombre As String, cuit As String)
        MyBase.New(nombre)
        Me.CUIT = cuit
    End Sub

    Public Overrides Function ToString() As String
        Return MyBase.ToString & CUIT
    End Function

End Class

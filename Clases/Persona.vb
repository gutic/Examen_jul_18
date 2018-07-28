Public Class Persona
    Inherits Propietario
    Private _DNI As UInteger

    Public Property DNI As UInteger
        Get
            Return _DNI
        End Get
        Set(value As UInteger)
            _DNI = value
        End Set
    End Property

    Sub New(nombre As String, dni As UInteger)
        MyBase.New(nombre)
        Me.DNI = dni
    End Sub

    Public Overrides Function ToString() As String
        Return MyBase.ToString & DNI
    End Function
End Class

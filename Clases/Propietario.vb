Imports Clases
'responsable de bidireccionalidad
Public MustInherit Class Propietario
    Implements iMultado

    Private _nombre As String
    Friend _vehiculo As List(Of Vehiculo)

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property


    Sub New(nombre As String)
        Me.Nombre = nombre
        _vehiculo = New List(Of Vehiculo)
    End Sub

    'En el diagrama add y remove vehiculo son friend, cambié a public por conveniencia

    Public Sub addVehiculo(vehiculo As Vehiculo)
        If vehiculo.Propietario IsNot Nothing Then
            Dim otroVehiculo = vehiculo.Propietario
            otroVehiculo.removeVehiculo(vehiculo)
        End If
        vehiculo.Propietario = Me
        _vehiculo.Add(vehiculo)
    End Sub

    Public Sub removeVehiculo(vehiculo As Vehiculo)
        vehiculo.Propietario = Nothing
        _vehiculo.Remove(vehiculo)
    End Sub

    Public Function getAllVehiculos() As List(Of Vehiculo)
        Return _vehiculo
    End Function

    Public Overrides Function ToString() As String
        Return Nombre
    End Function

    Public Function getAllMultas() As List(Of Multa) Implements iMultado.getAllMultas
        For Each vehiculo In _vehiculo
            Return vehiculo.getAllMultas
        Next
    End Function

    Public Function getTotalMultas() As Decimal Implements iMultado.getTotalMultas
        Dim totales As Decimal
        For Each multas In _vehiculo
            totales += Multa.MontoUnidad
        Next
        Return totales
    End Function
End Class

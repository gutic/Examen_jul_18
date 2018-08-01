Public Class Multa
    Private _Fecha As Date
    Private _Latitud As Decimal
    Private _Longitud As Decimal
    Private _Unidades As UShort
    Private Shared _montoUnidad As Decimal
    Private _Vehiculos As List(Of Vehiculo)

    Public Property Fecha As Date
        Get
            Return _Fecha
        End Get
        Set(value As Date)
            If value > Date.Now Then Throw New Exception("Fecha incorrecta")
            _Fecha = value
        End Set
    End Property

    Public Property Latitud As Decimal ' 
        Get
            Return _Latitud
        End Get
        Set(value As Decimal)
            If value < -90 Or value > 90 Then Throw New Exception("Latitud excedida de rango")
            _Latitud = value
        End Set
    End Property

    Public Property Longitud As Decimal
        Get
            Return _Longitud
        End Get
        Set(value As Decimal)
            If value < -180 Or value > 180 Then Throw New Exception("Longitud excedida de rango")
            _Longitud = value
        End Set
    End Property

    Public Property Unidades As Decimal
        Get
            Return _Unidades
        End Get
        Set(value As Decimal)
            _Unidades = value
        End Set
    End Property

    Public Shared Property MontoUnidad As Decimal
        Get
            Return _montoUnidad
        End Get
        Set(value As Decimal)
            _montoUnidad = value
        End Set
    End Property


    Sub New(vehiculo As Vehiculo, fecha As Date, latitud As Decimal, longitud As Decimal, unidades As Decimal)
        _Vehiculos = New List(Of Vehiculo)
        Me.addVehiculo(vehiculo)
        Me.Fecha = fecha
        Me.Latitud = latitud
        Me.Longitud = longitud
        Me.Unidades = unidades
    End Sub

    Public Sub addVehiculo(vehiculo As Vehiculo)
        _Vehiculos.Add(vehiculo)
    End Sub

    Public Function CalcularMonto() As Decimal
        Return Unidades * MontoUnidad
    End Function

    Public Overrides Function ToString() As String
        Return vehic
    End Function

End Class

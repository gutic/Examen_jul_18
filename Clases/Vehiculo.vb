Imports Clases

Public Class Vehiculo
    Implements iMultado
    Private _multas As List(Of Multa)
    Private _Patente As String
    Private _propietario As Propietario

    Public Property Propietario As Propietario
        Get
            Return _propietario
        End Get
        Friend Set(value As Propietario)
            _propietario = value
        End Set
    End Property


    Public Property Patente As String
        Get
            Return _Patente
        End Get
        Set(value As String)
            If value.Length < 6 Or value.Length > 8 Then Throw New Exception("Longitud excedida de rango")
            _Patente = value
        End Set
    End Property

    Sub New(patente As String)
        _multas = New List(Of Multa)
        Me.Patente = patente

    End Sub

    Friend Sub addMulta(Multa As Multa)
        _multas.Add(Multa)
    End Sub

    Public Overrides Function ToString() As String
        Return Patente & _propietario.ToString
    End Function

    Public Function getAllMultas() As List(Of Multa) Implements iMultado.getAllMultas
        Return _multas
    End Function

    Public Function getTotalMultas() As Decimal Implements iMultado.getTotalMultas
        Dim totales As Decimal
        For Each multas In _multas
            totales += Multa.MontoUnidad
        Next
        Return totales
    End Function
End Class

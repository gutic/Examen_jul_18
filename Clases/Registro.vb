Public Class Registro
    Private Shared _multa As New List(Of Multa)
    Private Shared _propietario As New List(Of Propietario)
    Private Shared _Persona As New List(Of Persona)

    Shared Sub New()
        _multa = New List(Of Multa)
        _propietario = New List(Of Propietario)
        _Persona = New List(Of Persona)
    End Sub

    'No se.________________________
    Public Shared Function getMultasByMultado(iMultado As Multa) As List(Of Multa)
        Return _multa.Contains(iMultado)

    End Function
    '______________________________

    Public Shared Function getAllPropietariosMultados() As List(Of Propietario)
        Return _propietario
    End Function

    Public Shared Function getPersonaByDNI(dni As UInteger)
        Return _Persona
    End Function

    Public Shared Sub addMulta(multa As Multa)
        _multa.Add(multa)
    End Sub


End Class

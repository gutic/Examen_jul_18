Imports Clases
Module Module1

    Sub Main()
        Dim auto As New Vehiculo("bxp 113")
        Dim moto As New Vehiculo("zxc 123")

        Dim duenio1 As New Persona("pepe", 35455734)

        duenio1.addVehiculo(moto)
        duenio1.addVehiculo(auto)

        Console.WriteLine(duenio1)
        For Each vehiculo In duenio1.getAllVehiculos
            Console.WriteLine(vehiculo)
        Next

        duenio1.removeVehiculo(moto)

        For Each vehiculo In duenio1.getAllVehiculos
            Console.WriteLine(vehiculo)
        Next

        Dim multa1 As New Multa(moto, #07/27/2018#, 12, 23, 2)
        multa1.addVehiculo(auto)
        Multa.MontoUnidad = 2000
        Console.WriteLine(multa1.CalcularMonto())

        Console.WriteLine(multa1.ToString())

    End Sub

End Module

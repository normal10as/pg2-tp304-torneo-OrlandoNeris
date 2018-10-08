
Imports Entidades

Module Equipo_Test

    Sub main()

        Dim Equipo1 = New Equipo("Los Tapitas")

        Console.WriteLine("Nombre: " & Equipo1.Nombre)
        Console.WriteLine("ToString: " & Equipo1.ToString)

        Console.ReadKey()

    End Sub

End Module

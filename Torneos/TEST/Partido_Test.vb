
Imports Entidades

Module Partido_Test

    Sub main()

        Dim equipolocal = New Equipo("las tacuaritas")
        Dim equipovisitante = New Equipo("las chauchas")

        Dim partido1 = New Partido(1, equipolocal, equipovisitante)

        MostrarTodo(partido1)

        partido1 = New Partido(2, equipovisitante, equipolocal, 5, 6)

        MostrarTodo(partido1)


        Console.ReadKey()

    End Sub

    Private Sub MostrarTodo(partido1 As Partido)
        Console.WriteLine("Jornada: " & partido1.Jornada)
        Console.WriteLine("Equipo Local: " & partido1.EquipoLocal.ToString)
        Console.WriteLine("Equipo Visitante: " & partido1.EquipoVisitante.ToString)
    End Sub
End Module

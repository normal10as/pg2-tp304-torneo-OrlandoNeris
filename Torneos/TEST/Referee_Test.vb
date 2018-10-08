
Imports Entidades

Module Referee_Test
    Sub main()
        Dim Referee1 = New Referee("Mariano", #02/02/1990#, True)

        Console.WriteLine()
        Console.WriteLine("Nombre: " & Referee1.Nombre)
        Console.WriteLine("Internacional: " & Referee1.Internacional)
        Console.WriteLine("Fecha de Nacimiento: " & Referee1.FechaNac)
        Console.WriteLine("Edad: " & Referee1.Edad)
        Console.WriteLine("ToString: " & Referee1.ToString)

        Console.ReadKey()

    End Sub

End Module

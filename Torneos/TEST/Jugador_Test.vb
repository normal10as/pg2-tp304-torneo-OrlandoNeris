
Imports Entidades

Module Jugador_Test

    Sub Main()

        Dim Jugador1 = New Jugador("Pepe", #08/02/1993#, 10)
        Console.WriteLine()
        Console.WriteLine("Nombre: " & Jugador1.Nombre)
        Console.WriteLine("Numero: " & Jugador1.Numero)
        Console.WriteLine("Fecha de Nacimiento: " & Jugador1.FechaNac)
        Console.WriteLine("Edad: " & Jugador1.Edad)
        Console.WriteLine("ToString: " & Jugador1.ToString)

        Console.ReadKey()
    End Sub

End Module

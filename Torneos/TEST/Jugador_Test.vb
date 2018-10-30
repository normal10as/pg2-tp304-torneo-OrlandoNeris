
Imports Entidades

Module Jugador_Test

    Sub Main()
        Dim jugador1 As Jugador

        Try
            jugador1 = New Jugador("", #08/02/1993#, 10)
        Catch ex As ArgumentException
            Console.WriteLine(ex.Message)
        End Try

        Try
            jugador1 = New Jugador(" asdasdasdsadasdas dsa asd asd ad asdas d as dpepe", #08/02/1993#, 10)
        Catch ex As ArgumentException
            Console.WriteLine(ex.Message)
        End Try

        Try
            jugador1 = New Jugador(" pepe", #08/02/1993#, 0)
        Catch ex As ArgumentException
            Console.WriteLine(ex.Message)
        End Try

        Try
            jugador1 = New Jugador(" pepe", #08/02/1993#, 100)
        Catch ex As ArgumentException
            Console.WriteLine(ex.Message)
        End Try

        Try
            jugador1 = New Jugador(" pepe", #08/02/1993#, 10)
        Catch ex As ArgumentException
            Console.WriteLine(ex.Message)
        End Try


        Console.WriteLine()
        Console.WriteLine("Nombre: " & Jugador1.Nombre)
        Console.WriteLine("Numero: " & Jugador1.Numero)
        Console.WriteLine("Fecha de Nacimiento: " & Jugador1.FechaNacimiento)
        Console.WriteLine("Edad: " & Jugador1.Edad)
        Console.WriteLine("ToString: " & Jugador1.ToString)

        Console.ReadKey()
    End Sub

End Module

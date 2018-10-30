
Imports Entidades

Module Equipo_Test

    Sub main()

        Dim Equipo1 = New Equipo("Los Tapitas")

        Console.WriteLine("Nombre: " & Equipo1.Nombre)
        Console.WriteLine("ToString: " & Equipo1.ToString)
        Dim jugador1 As New Jugador("pepe", #02/08/1993#, 10)
        Dim jugador2 As New Jugador("mario", #02/08/1994#, 11)
        Equipo1.ComprarJugador(jugador1)
        Equipo1.ComprarJugador(jugador2)

        MostrarJugadores(Equipo1)

        Equipo1.LiberarJugador(jugador1)

        MostrarJugadores(Equipo1)

        Dim equipo2 As New Equipo("Las tacuaritas")

        Equipo1.VenderJugador(jugador2, equipo2)
        Try
            Equipo1.VenderJugador(jugador2, equipo2)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        MostrarJugadores(Equipo1)
        MostrarJugadores(equipo2)

        Try
            If jugador1.Equipo Is Nothing Then
                Console.WriteLine("El jugador " & jugador1.Nombre & " no tiene equipo. ")
            End If
        Catch ex As Exception

        End Try

        Console.ReadKey()

    End Sub

    Private Sub MostrarJugadores(Equipo1 As Equipo)
        Console.WriteLine("Lista de jugadores del equipo" & Equipo1.ToString)
        For Each jugador In Equipo1.getAllJugadores
            Console.WriteLine(jugador.ToString & " Juego en el equipo: " & Equipo1.ToString)
        Next
    End Sub
End Module

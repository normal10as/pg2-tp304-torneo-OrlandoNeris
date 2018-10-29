Public Class Equipo

    Private _nombre As String
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value.Length > 0 And value.Length <= 30 Then
                _nombre = value
            End If
        End Set
    End Property

    Private _jugadores As List(Of Jugador)

    Sub New(nombre As String)
        Me.Nombre = nombre
        _jugadores = New List(Of Jugador)
    End Sub

    Public Overrides Function ToString() As String
        Return Nombre
    End Function

    Public Sub ComprarJugador(jugador As Jugador)
        jugador.Equipo = Me
        _jugadores.Add(jugador)
    End Sub

    Public Sub LiberarJugador(jugador As Jugador)
        jugador.Equipo = Nothing
        _jugadores.Remove(jugador)
    End Sub

    Public Sub VenderJugador(jugador As Jugador, equipodestino As Equipo)
        equipodestino.ComprarJugador(jugador)
        _jugadores.Remove(jugador)
    End Sub

    Public Function getAllJugadores() As List(Of Jugador)
        Return _jugadores
    End Function

End Class
